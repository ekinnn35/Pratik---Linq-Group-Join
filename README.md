# LINQ Join - Library Management System

## Description
This project implements a simple library management system using LINQ. The system consists of two tables: **Authors** and **Books**. The goal is to join these tables using LINQ and display the book titles along with their respective authors.

## Features
- Define **Author** and **Book** classes.
- Store author and book data in lists.
- Establish a relationship between books and authors using the **AuthorId** field.
- Use LINQ to join both lists and retrieve the book title along with the author's name.
- Display the results in a formatted manner.

## Data Structure
Each **Author** is represented as an object with:
- **AuthorId** (int): Unique identifier for the author.
- **Name** (string): The name of the author.

Each **Book** is represented as an object with:
- **BookId** (int): Unique identifier for the book.
- **Title** (string): The title of the book.
- **AuthorId** (int): Foreign key linking to the Author table.

## Example Data
```csharp
List<Author> authors = new List<Author>
{
    new Author { AuthorId = 1, Name = "Orhan Pamuk" },
    new Author { AuthorId = 2, Name = "Elif Safak" },
    new Author { AuthorId = 3, Name = "Ahmet Umit" }
};

List<Book> books = new List<Book>
{
    new Book { BookId = 1, Title = "Kar", AuthorId = 1 },
    new Book { BookId = 2, Title = "Istanbul", AuthorId = 1 },
    new Book { BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2 },
    new Book { BookId = 4, Title = "Beyoglu Rapsodisi", AuthorId = 3 }
};
```

## LINQ Query
```csharp
var bookWithAuthors = from book in books
                      join author in authors on book.AuthorId equals author.AuthorId
                      select new { book.Title, author.Name };

Console.WriteLine("Books and Their Authors:");
foreach (var item in bookWithAuthors)
{
    Console.WriteLine($"{item.Title} - {item.Name}");
}
```

## Expected Output
```
Books and Their Authors:
Kar - Orhan Pamuk
Istanbul - Orhan Pamuk
10 Minutes 38 Seconds in This Strange World - Elif Safak
Beyoglu Rapsodisi - Ahmet Umit
```

## Requirements
- .NET Core / .NET 5+
- Visual Studio or any C# compatible IDE

## How to Run
1. Clone the repository.
2. Open the solution in Visual Studio.
3. Run the program to see the joined results in the console.
