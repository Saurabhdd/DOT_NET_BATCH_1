using System;

namespace DynamicArrays
{
    public class OrderedDynamicArray<T> : DynamicArray<T> where T:IComparable
    {
        #region Constructor

        public OrderedDynamicArray() :base()
        {
        }

        #endregion

        #region Public methods
        public override void Add(T item)
        {
            if(count == items.Length)
                Expand();
            
            int addLocation = 0;
            while((addLocation < count) && (items[addLocation].CompareTo(item) < 0))
                addLocation++;
            ShiftUp(addLocation);
            items[addLocation] = item;
            count++;
        }

        public override bool Remove(T item)
        {
            int itemLocation = IndexOf(item);
            if(itemLocation < 0)
                return false;
            ShiftDown(itemLocation + 1);
            count--;
            return true;
        }

        public override int IndexOf(T item)
        {
            int lowerBound = 0;
            int upperBound = count - 1;
            T middleValue;
            int location = -1;

            while((location == -1) && (lowerBound <= upperBound))
            {
                int middleLocation = lowerBound + (upperBound - lowerBound);
                middleValue = items[middleLocation];
                if(middleValue.CompareTo(item) == 0)
                    location = middleLocation;
                else
                {
                    if(middleValue.CompareTo(item) < 0)
                        lowerBound = middleLocation + 1;
                    else 
                        upperBound = middleLocation - 1;
                    
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
