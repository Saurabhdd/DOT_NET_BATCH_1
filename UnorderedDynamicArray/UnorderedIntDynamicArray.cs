using System;

namespace DynamicArrays
{
    public class UnorderedIntDynamicArray : IntDynamicArray
    {
        #region Constructor

        public UnorderedIntDynamicArray()
            :base()
        {
        }

        #endregion

        #region Public methods
        public override void Add(int item)
        {
            if(count == items.Length)
                Expand();
            
            items[count] = item;
            count++;
        }

        public override bool Remove(int item)
        {
            int itemLocation = IndexOf(item);
            if(itemLocation == -1)
                return false;
            else
            {
                items[itemLocation] = items[count - 1];
                count--;
                return true;
            }
        }

        public override int IndexOf(int item)
        {
            for(int i = 0; i < count; i++)
            {
                if(items[i] == item)
                    return i;
            }
            return -1;  
        }

        #endregion
    }
}
