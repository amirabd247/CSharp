using System.Diagnostics.SymbolStore;
using System.Threading.Channels;

// string symbol;
// int length;
//
// Console.WriteLine("Enter the symbol whatever u want");
// symbol = Console.ReadLine();
// Console.WriteLine("Enter the length of the symbol");
// length = Convert.ToInt32(Console.ReadLine());
//
// square(symbol,length);
//
// void square(string sym, int len)
// {
//     for (int i = 0; i < len; i++)
//     {
//         for (int j = 0; j < len; j++)
//         {
//             Console.Write($"{sym} ");
//         }
//         Console.WriteLine();
//     }
// }



// int num;
// Console.WriteLine("Enter the number");
// num = Convert.ToInt32(Console.ReadLine());
// int num2 = 0;
// bool palindrom(int num,int num2)
// {
//     int num1 = num;
//     while (num1 > 0)
//     {
//         num2 = (num2 * 10) + num1 % 10;
//         num1 /= 10;
//     }
//
//     if (num == num2)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
//
// if (palindrom(num, num2))
// {
//     Console.WriteLine("palindrom");
// }
// else
// {
//     Console.WriteLine("no");
// }


// List<int> numbers = new List<int>();
// List<int> numberstodelete = new List<int>();
// Random number = new Random();
//
// for (int i = 0; i < 7; i++)
// {
//     numbers.Add(number.Next(-10,10));
// }
//
// for (int i = 0; i < 4; i++)
// {
//     numberstodelete.Add(number.Next(-10,10));
// }
//
// for (int i = 0; i < numberstodelete.Count; i++)
// {
//     numbers.RemoveAll(item => item == numberstodelete[i]);
// }
//
// foreach (var item in numbers)
// {
//     Console.Write($"{item} ");
// }


// Website site = new Website()
// {
//     Name = "mystat",
//     Description = "education site",
//     IP = "54.32.66.233"
// };
//
//
// class Website
// {
//     public string Name { get; set; }
//     public string Description{ get; set; }
//     public string IP{ get; set; }
// }


// Magazine journal = new Magazine()
// {
//     Name = "thunder",
//     Founding_date = new DateTime(2015, 2, 2), 
//     Description = "a source of lightning-fast news and scientific discoveries", 
//     Number = 15551234567,
//     Email = "contact@thundermagazine.com"
// };
//
// class Magazine
// {
//     public string Name { get; set; }
//     public DateTime Founding_date { get; set; }
//     public string Description { get; set; }
//     public long Number { get; set; }
//     public string Email { get; set; }
// }


Shop journal = new Shop()
{
    Name = "Benco",
    Adress = @"
                123 Main Street,
                Cityville,
                Stateville,
                ZIP: 12345,
                USA
              ", 
    Description = "your reliable partner in the world of style and comfort", 
    Number = 15551234567,
    Email = " info@bencostore.com"
};

class Shop
{
    public string Name { get; set; }
    public string Adress { get; set; }
    public string Description { get; set; }
    public long Number { get; set; }
    public string Email { get; set; }
}