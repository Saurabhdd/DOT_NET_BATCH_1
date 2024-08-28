class Test
{
	static void Main()
	{
		//array of integers
		int[] nums = new int[5];
		// Array of strings
		string[ ] names = new string[2];

		for(int i =0; i< nums.Length; i++)
            nums[i] = i+2;

		names[0] = "Mahesh";
		names[1] = "Chand";

        for (int i = 0; i< nums.Length; i++)
            System.Console.WriteLine ("num[{0}] = {1}", i, nums[i] );   
        
        System.Console.WriteLine(names[0].ToString() + " " + names[1].ToString() );

        char[] arr1 =new char[] {'a', 'b', 'c'};
        int[,] arrr2 = new int[,] {{2,4}, {3, 5}}; 
        //rectangular array declaration
        int [, ,]arr3= new int[2,4,6]; 
        // also rectangular
        int[][]jarr = new int[3][]; 
        //jagged array declaration 
        jarr[0] = new int[] {1,2,3};
        jarr[1] = new int[] {1,2,3,4,5,6};
        jarr[2] = new int[] {1,2,3,4,5,6,7,8,9}; 	 

    }
}
