using System;

namespace Arrays
{
    internal class Array
    {
        int[] items;
        public const int MAX_LENGH = 10;
        int index;
        const int ExpandMultiplyFactor = 2;
        

        public Array()
        {
            items = new int[MAX_LENGH];
            index = 0;
        }

        public void Add(int data)
        {
            if(index == items.Length)
                Expand();

            items[index++] = data;
        }

        public bool Remove(int data)
        {
            int itemIndex = IndexOf(data);
            if(itemIndex == -1)
                return false;
            items[itemIndex] = items[MAX_LENGH - 1];
            index--;
            return true;

        }

        public int IndexOf(int data)
        {
            for(int i = 0; i < MAX_LENGH; i++)
                if(items[i] == data)
                    return i;
            return -1;
        }

        public void Print()
        {
            for(int i = 0; i < index; i++)
                Console.Write("[" + items[i] + "]");
            Console.WriteLine("[END]");
        }


        private void Expand()
        {
            int[] newItems = new int[items.Length * ExpandMultiplyFactor];

            for(int i = 0; i < items.Length; i++)
                newItems[i] = items[i];

            items = newItems;
        }

        
    }
}


/*


public override void Add(int item)
        {
            if(count == items.Length)
                Expand();

            int addLocation = 0;
            while((addLocation < count) && (items[addLocation] < item))
                addLocation++;
            ShiftUp(addLocation);
            items[addLocation] = item;
            count++;
        }

        public override bool Remove(int item)
        {
            int itemLocation = IndexOf(item);
            if(itemLocation == -1)
                return false;

            ShiftDown(itemLocation + 1);
            count--;
            return true;
        }

        public override int IndexOf(int item)
        {
            int lowerBound = 0;
            int upperBound = count - 1;
            int location = -1;

            while((location == -1) && (lowerBound <= upperBound))
            {
                int middleLocation = lowerBound + (upperBound - lowerBound);
                int middleValue = items[middleLocation];
                if(middleValue == item)
                    location = middleLocation;
                else
                {
                    if(middleValue > item)
                        upperBound = middleLocation - 1;
                    else 
                        lowerBound = middleLocation + 1;

                    if(lowerBound > upperBound)
                        break;
                }
            }
            return location;
        }

        #endregion

        #region Private methods
        void ShiftUp(int index)
        {
            for(int i = count; i > index; i--)
                items[i] = items[i - 1];
        }

        void ShiftDown(int index)
        {
            for(int i = index; i < count; i++)
                items[i - 1] = items[i];
        }
*/