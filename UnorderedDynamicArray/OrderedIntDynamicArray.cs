using System;

namespace DynamicArrays
{
    public class OrderedIntDynamicArray : IntDynamicArray
    {
        #region Constructor

        public OrderedIntDynamicArray()
            :base()
        {
        }

        #endregion

        #region Public methods

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

        #endregion

    }
}
