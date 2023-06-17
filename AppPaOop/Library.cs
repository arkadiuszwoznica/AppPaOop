using System;
using AppPaOop;
using AppPaOop.Items;
using AppPaOop.Users;

namespace AppPaOop
{
	public class Library
	{
        public List<UserBase> Users;
        public List<ItemBase> Items;
        public HeadLibrarian HeadLibrarian;


        public Library(List<UserBase> users, List<ItemBase> items, HeadLibrarian headLibrarian)
        {
            Users = users;
            Items = items;
            HeadLibrarian = headLibrarian;
        }


        public void BorrowItem(UserBase user, ItemBase item)
        {
            if (CanBeBorrowed(user, item))
            {
                Record record = new Record(item.Id, user, DateTime.Today, null);
                item.IsBorrowed = true;
                user.borrowedItems.Add(item);
                HeadLibrarian.records.Add(record);
                Console.WriteLine("Item borrowed successfully");
            }
            else
            {
                Console.WriteLine("Item can't be borrowed. It's borrowed already " +
                    "or user can't borrow (has maximum number or is banned).");
            }
        }

        private bool CanBeBorrowed(UserBase user, ItemBase item)
        {
            return item.IsAvailableToBeBorrowed() && user.CanBorrow();
        }

        public void ReturnItem(UserBase user, ItemBase item)
        {
            Record currentRecord = HeadLibrarian.GetRecord(item);
            currentRecord.DayOfReturning = DateTime.Today;

            item.IsBorrowed = false;
            user.borrowedItems.Remove(item);

            if (user.WasUserLate(currentRecord))
            {
                user.BeingLateCounter++;
                Console.WriteLine("User was late, I'm increasing BeingLateCounter");
            }

            user.CheckForBlocking();
            if (user.Blocked == true)
            {
                Console.WriteLine("User is now blocked");
            }
        }

        private UserBase? LongestOverdue()
        {
            int mostDaysOfOverdue = 0;

            foreach (UserBase user in Users)
            {
                foreach (ItemBase item in user.borrowedItems)
                {
                    if (item.DaysOfBeingBorrowed - user.MaximumDaysOfBorrowing > mostDaysOfOverdue)
                    {
                        UserBase longestOverduing = user;
                        return longestOverduing;
                    }
                }
            }
            return null;
        }

        public string ShameOverdued()
        {
            UserBase user = LongestOverdue();

            if (user != null)
            {
                return $"Currently the longest overduing user is {user.Name}";
            }
            else
            {
                return "None uf users is overduing now, thank you :)";
            }
        }
    }
}