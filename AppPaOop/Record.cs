using System;
using AppPaOop.Users;

namespace AppPaOop
{
    public class Record
    {
        public int ItemId;
        public UserBase User;
        public DateTime DayOfBorrowing;
        public DateTime? DayOfReturning;

        public Record(int itemId, UserBase user, DateTime dayOfBorrowing, DateTime? dayOfReturning)
        {
            ItemId = itemId;
            User = user;
            DayOfBorrowing = dayOfBorrowing;
            DayOfReturning = dayOfReturning;
        }
    }
}