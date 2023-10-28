# AppPaOop
Hi there!

You're seeing code of my app simulating library system. 
It's divided into classes, using constructs such as enums, inheritance and nullables, 
everything in accordance with the art of object-oriented programming. 

Happy librarying!


## Classes overview

### Items

In this folder you can find classes representing items which could be borrowed from
library. It is a base class for them, cd and book classes are its implementations.
Additionally, the booktype is enum representing types in which book could be.

### Users 

In this folder you can find classes representing possible library users. It is base
class and Student and Resident classes, which are its implementations and differ from 
each other in possible time of borrowing and maximum quantity of borrowed books.

### Other classes

Record - this class is a schema of one record which is made when someone is borrowing.

HeadLibrarian - this class is a representation of librarian who has a list of all borrowed items.

Library - here you have main logic of library simulator. This class holds methods of borrowing
and also looks if the user is not overduing with returning.

Program - here you can find some example data for simulation. Feel free to edit this file!


## Running the app

Follow the instructions below to clone, compile, and run the Java Console App.

### Clone the Repository

If you have Git installed, you can clone the repository with the following command:

```bash
git clone https://github.com/arkadiuszwoznica/OopLibrary
```

### Run the Application

I strongly recommend you using it to run this app in IDE cooperating with C# to have best overview on project and possibility of recreating Program.cs to make your scenario in this simulation. 
