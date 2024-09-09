#ifndef _DCLL_H 
#define _DCLL_H

#define SUCCESS             1
#define TRUE                1
#define FAILURE             0
#define FALSE               0
#define E_INVALID_HANDLE    -1
#define E_INVALID_VALUE     -2
#define LIST_EMPTY          -3

typedef struct node node_t;
typedef node_t list_t;
typedef int data_t;
typedef int status_t;
typedef int handle;
typedef long long ssize_t;

struct node
{
    data_t data;
    struct node* prev;
    struct node* next;
};


void init_list_lib(void);
handle create_list(void);
status_t insert_start(handle list_handle, data_t data_to_insert);
status_t insert_end(handle list_handle, data_t data_to_insert);
status_t insert_after(handle list_handle, data_t data_to_insert, data_t ref_data);
status_t insert_before(handle list_handle, data_t data_to_insert, data_t ref_datas);

status_t get_end(handle list_handle, data_t* get_data);
status_t get_start(handle list_handle, data_t* get_data);
status_t pop_end(handle list_handle, data_t* get_data);
status_t pop_start(handle list_handle, data_t* get_data);
status_t remove_end(handle list_handle);
status_t remove_start(handle list_handle);
status_t remove_data(handle list_handle, data_t data_to_remove);
status_t find(handle list_handle, data_t data_to_find);
status_t show(handle list_handle, const char* msg);
status_t length(handle list_handle, ssize_t* length);
status_t is_list_empty(handle list_handle);
status_t clear_list(handle list_handle);
status_t release_list(handle list_handle);
void release_list_lib(void);

/*Inter list routines*/
handle get_concatenated_list(handle p_list_1, handle p_list_2);
status_t concat_list(handle p_list_1, handle p_list_2);
handle merge_lists(handle p_list_1, handle p_list_2);
status_t to_array(handle p_list, data_t** pp_arr);
handle to_list(data_t* p_array, ssize_t N);
handle get_reversed_list(handle h_list);

/*auxilary functions*/
static status_t destroy_list(handle list_handle);
static status_t generic_insert(node_t* start, node_t* mid, node_t* end);
static status_t generic_delete(node_t* node_to_delete);
static node_t* get_node(data_t data);
static void* xmalloc(size_t size_in_bytes);
status_t CHECK_HANDLE(handle H);


#endif /*_DCLL_H*/