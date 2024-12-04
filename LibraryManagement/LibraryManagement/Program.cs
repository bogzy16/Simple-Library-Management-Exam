using LibraryManagement.Model;
using LibraryManagement.Service;
using System.Runtime.InteropServices;

// Create a Borrower
BorrowedItemService borrower = new BorrowedItemService("Sebastian");

// Create Books and Add it to created borrower
BookModel data1 = new BookModel()
{
    Id = new Guid("f4c6cb7b-b0a1-44d8-b86f-12878d4844a1"),
    Title = "Book of Eli",
    Author = "Jose Bonifacio",
    Isbn = "A-0060-Z"
};

BookModel data2 = new BookModel()
{
    Id = new Guid("2b1d01b0-7b00-4904-9b6f-ff78d8c36b44"),
    Title = "Book for Dummy",
    Author = "Apolinario Aguinaldo",
    Isbn = "A-0100-Z"
};

borrower.BorrowItem(data1);
borrower.BorrowItem(data2);

// Display Borrowed Items
borrower.DisplayBorrowedItems();
Console.WriteLine("");

// Returned Borrowed Item
borrower.ReturnItem(data1);
Console.WriteLine("");

Console.WriteLine("Redisplay items after Borrower Return an Item");
Console.WriteLine("");

borrower.DisplayBorrowedItems();

Console.ReadLine();



