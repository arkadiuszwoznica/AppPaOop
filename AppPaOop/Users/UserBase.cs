using System;
using AppPaOop;
using AppPaOop.Items;

namespace AppPaOop.Users
{
	public abstract class UserBase
	{
        public string Name;
        public int Id;
        public int MaximumAmountOfItems;
        public int MaximumDaysOfBorrowing;
        public int BeingLateCounter;
        public bool Blocked;
        public List<ItemBase> borrowedItems = new List<ItemBase>();
        public int ObjectsCounter = 0;


        public void CheckForBlocking()
        {
            if (this.BeingLateCounter >= 3)
            {
                this.Blocked = true;
            }
        }

        public bool WasUserLate(Record record)
        {
            DateTime dayOfReturning = record.DayOfReturning ?? default(DateTime);
            TimeSpan timeSpan = dayOfReturning - record.DayOfBorrowing;
            int timeInDays = timeSpan.Days;

            if (timeInDays > this.MaximumDaysOfBorrowing)
            {
                return true;
            }
            return false;
        }

        public bool CanBorrow()
        {
            return this.borrowedItems.Count() < this.MaximumAmountOfItems && !this.Blocked;
        }
    }
}