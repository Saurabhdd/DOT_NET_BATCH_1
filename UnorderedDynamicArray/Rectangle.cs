using System;

namespace ImplementingAnInterface 
{
    public class Rectangle : IComparable
    {
        #region Fields
        int width;
        int height;

        #endregion

        #region Constructors
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        #endregion

        #region Properties
        public int Width
        {
            get {return width;}
        }

        public int Height
        {
            get {return height;}
        }
        #endregion

        #region Methods
        public override String ToString()
        {
            return string.Format("[Rectangle: Width = {0}, Height = {1}]", width, height);
        }

        public int CompareTo(Object obj)
        {
            if(obj == null)
                return 1;
            
            Rectangle otherRectangle = obj as Rectangle;
            if(otherRectangle != null)
            {
                if(width * height < otherRectangle.Width * otherRectangle.Height)
                    return -1;
                else if(width * height == otherRectangle.Width * otherRectangle.Height)
                    return 0;
                return 1;
            }
                throw new ArgumentException("Object is not of type Rectangle");
        }

        #endregion
    }
}
