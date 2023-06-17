using System;
using System.Numerics;
using AppPaOop.Items;
using AppPaOop.Users;

namespace AppPaOop
{
    public static class Program
    {
        public static void Main()
        {
            HeadLibrarian headLibrarian = new HeadLibrarian();

            Student student = new Student("Adam");
            Student student1 = new Student("Kasia");
            Student student2 = new Student("Basia");
            Student student3 = new Student("Mirek");
            Student student4 = new Student("Darek");
            Resident resident = new Resident("Ania");
            Resident resident1 = new Resident("Hania");
            Resident resident2 = new Resident("Piotr");

            List<UserBase> users = new List<UserBase>();
            users.Add(student);
            users.Add(student1);
            users.Add(student2);
            users.Add(student3);
            users.Add(student4);
            users.Add(resident);
            users.Add(resident1);
            users.Add(resident2);

            Book book = new Book("Anna Karenina", 850, BookTypes.Novel);
            Book book1 = new Book("Pani Bovary", 350, BookTypes.Novel);
            Book book2 = new Book("Ulisses", 650, BookTypes.Novel);
            Book book3 = new Book("Encyklopedia zwierząt", 850, BookTypes.Encyclopedia);
            Book book4 = new Book("Historia powszechna tom 1", 340, BookTypes.Textbook);
            CD cd = new CD("Michael Jackson", 12);
            CD cd1 = new CD("Czesław Niemen", 16);
            CD cd2 = new CD("Dawid Podsiadło", 10);

            List<ItemBase> items = new List<ItemBase>();
            items.Add(book);
            items.Add(book1);
            items.Add(book2);
            items.Add(book3);
            items.Add(book4);
            items.Add(cd);
            items.Add(cd1);
            items.Add(cd2);

            Library library = new Library(users, items, headLibrarian);


            library.BorrowItem(library.Users[1], library.Items[0]);
            Console.WriteLine(library.Items[0].IsBorrowed);

            //library.BorrowItem(library.Users[2], library.Items[0]);
            //Console.WriteLine(library.Users[2].borrowedItems[0]);

            library.ReturnItem(library.Users[1], library.Items[0]);
            Console.WriteLine(library.Items[0].IsBorrowed);

            library.BorrowItem(library.Users[2], library.Items[0]);
            Console.WriteLine(library.Users[2].borrowedItems[0]);


            //library.BorrowItem(library.Users[6], library.Items[0]);
            //library.BorrowItem(library.Users[6], library.Items[1]);
            //library.BorrowItem(library.Users[6], library.Items[2]);
            //library.BorrowItem(library.Users[6], library.Items[3]);


            Console.WriteLine(library.ShameOverdued());

            Console.ReadKey();
        }
    }
}