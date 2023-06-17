using System;

namespace AppPaOop.Items
{
	public class Book : ItemBase
    {
        public BookTypes Type;

        public Book(string name, int numberOfPages, BookTypes type)
        {
            ObjectsCounter++;
            Id = ObjectsCounter;
            Name = name;
            Length = numberOfPages;
            Type = type;
        }
    }
}