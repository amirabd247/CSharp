// Magazine magazine1 = new Magazine
// {
//     Name = "thunder",
//     Founding_date = new DateTime(2015, 2, 2),
//     Description = "a source of lightning-fast news and scientific discoveries",
//     Number = 15551234567,
//     Email = "contact@thundermagazine.com",
//     NumberOfEmployees = 10 
// };
//
// Magazine magazine2 = new Magazine
// {
//     Name = "lightning",
//     Founding_date = new DateTime(2018, 5, 10),
//     Description = "delivering the latest news and research findings",
//     Number = 9876543210,
//     Email = "contact@lightningmagazine.com",
//     NumberOfEmployees = 8 
// };
//
// magazine1 = magazine1 + 5;
// magazine2 = magazine2 + 3;
//
// magazine1 = magazine1 - 2;
// magazine2 = magazine2 - 1;
//
// bool areEqual = magazine1 == magazine2;
// Console.WriteLine($"Are the magazines equal in terms of employees: {areEqual}");
//
// bool areNotEqual = magazine1 != magazine2;
// Console.WriteLine($"Are the magazines not equal in terms of employees: {areNotEqual}");
//
// bool isMagazine1Less = magazine1 < magazine2;
// Console.WriteLine($"Is magazine1 less in terms of employees than magazine2: {isMagazine1Less}");
//
// bool isMagazine1Greater = magazine1 > magazine2;
// Console.WriteLine($"Is magazine1 greater in terms of employees than magazine2: {isMagazine1Greater}");
//
// bool areObjectsEqual = magazine1.Equals(magazine2);
// Console.WriteLine($"Are the objects equal in terms of employees: {areObjectsEqual}");
//
//
// class Magazine
// {
//     public string Name { get; set; }
//     public DateTime Founding_date { get; set; }
//     public string Description { get; set; }
//     public long Number { get; set; }
//     public string Email { get; set; }
//     
//     private int numberOfEmployees;
//     
//     public int NumberOfEmployees
//     {
//         get { return numberOfEmployees; }
//         set { numberOfEmployees = value; }
//     }
//     
//     public static Magazine operator +(Magazine magazine, int additionalEmployees)
//     {
//         magazine.NumberOfEmployees += additionalEmployees;
//         return magazine;
//     }
//     
//     public static Magazine operator -(Magazine magazine, int reduction)
//     {
//         magazine.NumberOfEmployees -= reduction;
//         return magazine;
//     }
//     
//     public static bool operator ==(Magazine magazine1, Magazine magazine2)
//     {
//         return magazine1.NumberOfEmployees == magazine2.NumberOfEmployees;
//     }
//
//     public static bool operator !=(Magazine magazine1, Magazine magazine2)
//     {
//         return magazine1.NumberOfEmployees != magazine2.NumberOfEmployees;
//     }
//
//     public static bool operator <(Magazine magazine1, Magazine magazine2)
//     {
//         return magazine1.NumberOfEmployees < magazine2.NumberOfEmployees;
//     }
//
//     public static bool operator >(Magazine magazine1, Magazine magazine2)
//     {
//         return magazine1.NumberOfEmployees > magazine2.NumberOfEmployees;
//     }
//
//     public override bool Equals(object obj)
//     {
//         if (obj == null || !(obj is Magazine))
//         {
//             return false;
//         }
//         Magazine otherMagazine = (Magazine)obj;
//         return this.NumberOfEmployees == otherMagazine.NumberOfEmployees;
//     }
// }



// Shop shop1 = new Shop
// {
//     Name = "Benco",
//     Adress = @"
//                 123 Main Street,
//                 Cityville,
//                 Stateville,
//                 ZIP: 12345,
//                 USA
//             ",
//     Description = "your reliable partner in the world of style and comfort",
//     Number = 15551234567,
//     Email = "info@bencostore.com",
//     NumberOfEmployees = 20 
// };
//
// Shop shop2 = new Shop
// {
//     Name = "StyleMasters",
//     Adress = @"
//                 456 Elm Avenue,
//                 Townsville,
//                 Stateville,
//                 ZIP: 54321,
//                 USA
//             ",
//     Description = "your one-stop shop for fashion and trends",
//     Number = 9876543210,
//     Email = "info@stylemasters.com",
//     NumberOfEmployees = 15 
// };
//
//         
// shop1 = shop1 + 5;
// shop2 = shop2 + 3;
//
//         
// shop1 = shop1 - 2;
// shop2 = shop2 - 1;
//
//         
// bool areEqual = shop1 == shop2;
// Console.WriteLine($"Are the shops equal in terms of employees: {areEqual}");
//
// bool areNotEqual = shop1 != shop2;
// Console.WriteLine($"Are the shops not equal in terms of employees: {areNotEqual}");
//
// bool isShop1Less = shop1 < shop2;
// Console.WriteLine($"Is shop1 less in terms of employees than shop2: {isShop1Less}");
//
// bool isShop1Greater = shop1 > shop2;
// Console.WriteLine($"Is shop1 greater in terms of employees than shop2: {isShop1Greater}");
//
// bool areObjectsEqual = shop1.Equals(shop2);
// Console.WriteLine($"Are the objects equal in terms of employees: {areObjectsEqual}");
//
// class Shop
// {
//     public string Name { get; set; }
//     public string Adress { get; set; }
//     public string Description { get; set; }
//     public long Number { get; set; }
//     public string Email { get; set; }
//
//     private int numberOfEmployees;
//
//     public int NumberOfEmployees
//     {
//         get { return numberOfEmployees; }
//         set { numberOfEmployees = value; }
//     }
//
//     public static Shop operator +(Shop shop, int additionalEmployees)
//     {
//         shop.NumberOfEmployees += additionalEmployees;
//         return shop;
//     }
//
//     public static Shop operator -(Shop shop, int reduction)
//     {
//         shop.NumberOfEmployees -= reduction;
//         return shop;
//     }
//
//     public static bool operator ==(Shop shop1, Shop shop2)
//     {
//         return shop1.NumberOfEmployees == shop2.NumberOfEmployees;
//     }
//
//     public static bool operator !=(Shop shop1, Shop shop2)
//     {
//         return shop1.NumberOfEmployees != shop2.NumberOfEmployees;
//     }
//
//     public static bool operator <(Shop shop1, Shop shop2)
//     {
//         return shop1.NumberOfEmployees < shop2.NumberOfEmployees;
//     }
//
//     public static bool operator >(Shop shop1, Shop shop2)
//     {
//         return shop1.NumberOfEmployees > shop2.NumberOfEmployees;
//     }
//
//     public override bool Equals(object obj)
//     {
//         if (obj == null || !(obj is Shop))
//         {
//             return false;
//         }
//         Shop otherShop = (Shop)obj;
//         return this.NumberOfEmployees == otherShop.NumberOfEmployees;
//     }
// }


// using System;
// using System.Collections.Generic;
//
//
//     ReadingList readingList = new ReadingList();
//
//     readingList += new Book("Book 1", "Author 1");
//     readingList += new Book("Book 2", "Author 2");
//
//     readingList.DisplayBooks();
//
//     Book bookToCheck = new Book("Book 1", "Author 1");
//     bool isBookInList = readingList.ContainsBook(bookToCheck);
//     Console.WriteLine($"Is '{bookToCheck}' in the reading list: {isBookInList}");
//
//     readingList -= bookToCheck;
//
//     readingList.DisplayBooks();
//
// class Book
// {
//     public string Title { get; set; }
//     public string Author { get; set; }
//
//     public Book(string title, string author)
//     {
//         Title = title;
//         Author = author;
//     }
//
//     public override string ToString()
//     {
//         return $"{Title} by {Author}";
//     }
// }
//
// class ReadingList
// {
//     private List<Book> books = new List<Book>();
//
//     public void AddBook(Book book)
//     {
//         books.Add(book);
//     }
//
//   
//     public void RemoveBook(Book book)
//     {
//         books.Remove(book);
//     }
//
//     public bool ContainsBook(Book book)
//     {
//         return books.Contains(book);
//     }
//
//     public static ReadingList operator +(ReadingList readingList, Book book)
//     {
//         readingList.AddBook(book);
//         return readingList;
//     }
//
//     public static ReadingList operator -(ReadingList readingList, Book book)
//     {
//         readingList.RemoveBook(book);
//         return readingList;
//     }
//
//     public Book this[int index]
//     {
//         get
//         {
//             if (index >= 0 && index < books.Count)
//             {
//                 return books[index];
//             }
//             else
//             {
//                 throw new IndexOutOfRangeException("Index is out of range");
//             }
//         }
//     }
//
//     public void DisplayBooks()
//     {
//         Console.WriteLine("Reading List:");
//         for (int i = 0; i < books.Count; i++)
//         {
//             Console.WriteLine($"{i + 1}. {books[i]}");
//         }
//     }
// }



