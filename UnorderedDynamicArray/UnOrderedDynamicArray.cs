using System;

namespace DynamicArrays
{
    public class UnOrderedDynamicArray<T> : DynamicArray<T>
    {
        #region Constructor
        public UnOrderedDynamicArray()
            :base()
        {
        }

        #endregion

        #region Public methods
        public override void Add(T item)
        {
            if(count < items.Length)
                Expand();
            items[count] = item;
            count++;
        }

        public override bool Remove(T item)
        {
            int itemLocation = IndexOf(item);
            if(itemLocation < 0)
                return false;
            items[itemLocation] = items[count - 1];
            count--;
            return true;
        }

        public override int IndexOf(T item)
        {
            for(int i = 0; i < count; i++)
            {
                if(items[i].Equals(item))
                    return i;
            }
            return -1;
        }

        #endregion
    }
}
