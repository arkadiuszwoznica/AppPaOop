using System;
namespace AppPaOop.Items
{
    public abstract class ItemBase
    {
        public string Name;
        public int Id;
        public int Length;
        public bool IsBorrowed;
        public int DaysOfBeingBorrowed;
        public int ObjectsCounter;

        public bool IsAvailableToBeBorrowed()
        {
            return !IsBorrowed;
        }
    }
}