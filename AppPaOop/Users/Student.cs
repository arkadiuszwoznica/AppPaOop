using System;
namespace AppPaOop.Users
{
	public class Student : UserBase
	{
        public Student(string name)
        {
            ObjectsCounter++;
            Name = name;
            Id = ObjectsCounter;
            MaximumAmountOfItems = 5;
            MaximumDaysOfBorrowing = 14;
        }
    }
}