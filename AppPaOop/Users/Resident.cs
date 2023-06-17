using System;
namespace AppPaOop.Users
{
	public class Resident : UserBase
	{
        public Resident(string name)
        {
            ObjectsCounter++;
            Name = name;
            Id = ObjectsCounter;
            MaximumAmountOfItems = 3;
            MaximumDaysOfBorrowing = 7;
        }
    }
}