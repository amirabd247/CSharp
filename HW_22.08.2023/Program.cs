// int num1;
//
// Console.WriteLine("Enter the number from 1 to 100");
// num1 = int.Parse(Console.ReadLine());
//
// if (num1 < 1 || num1 > 100)
// {
// throw new Exception("Error");
// }
//
// if (num1 % 3 == 0)
// {
//     Console.WriteLine("Fizz");
// }
// else if (num1 % 5 == 0)
// {
//     Console.WriteLine("Buzz");
// }
// else if (num1 % 3 == 0 && num1 % 5 == 0)
// {
//     Console.WriteLine("Fizz Buzz");
// }
// else if (num1 % 3 != 0 && num1 % 5 != 0)
// {
//     Console.WriteLine(num1);
// }

//____________________________________________

// double num;
// int percent;
//
// Console.WriteLine("Enter the number");
// num = int.Parse(Console.ReadLine());
//
// Console.WriteLine("Enter the percent");
// percent = int.Parse(Console.ReadLine());
//
// num = (num / 100) * percent;
//
// Console.WriteLine(num);

//____________________________________________

// int num1,num2,num3,num4;
// int totalnum;
//
// Console.WriteLine("Enter four numbers:");
//
// num1 = Convert.ToInt32(Console.ReadLine());
// num2 = Convert.ToInt32(Console.ReadLine());
// num3 = Convert.ToInt32(Console.ReadLine());
// num4 = Convert.ToInt32(Console.ReadLine());
//
// totalnum = num1 * 1000 + num2 * 100 + num3 * 10 + num4;
// Console.WriteLine(totalnum);

//____________________________________________

// int num;
// List<int> list = new List<int>();
// int i = 0 ;
//
// Console.WriteLine("Enter the 6-value number");
// num = Convert.ToInt32(Console.ReadLine());
//
// if (num < 100000 || num > 999999)
// {
//     throw new Exception("Error");
// }
//
// while (num > 0)
// {
//     list.Insert(0,num % 10);
//     num /= 10;
// }
//
// int value1, value2;
// Console.WriteLine("Enter the first value");
// value1 = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine("Enter the second value");
// value2 = Convert.ToInt32(Console.ReadLine());
//
// int tmpvalue;
//
// tmpvalue = list[value1 - 1];
// list[value1 - 1] = list[value2 - 1];
// list[value2 - 1] = tmpvalue;
//
// int totalnum = 0;
//
// int GetPow(int value,int value2)
// {
//     for (int j = 0; j < value2 - 1; j++)
//     {
//         value *= 10;
//     }
//
//     return value;
// }
//
//
// for (int item = 0; item < 6; item++)
// {
//     totalnum += list[item] * GetPow(1,6 - item);
// }
//     
//
//
// Console.WriteLine(totalnum);

//____________________________________________

// using System.Globalization;
//
// DateTime Date = new DateTime();
// Console.WriteLine("Enter the date(example: 11.11.2011");
// string Dateexm = Console.ReadLine();
//
// Date = DateTime.ParseExact(Dateexm, "dd.MM.yyyy", CultureInfo.InvariantCulture);
//
// Console.WriteLine(Date.DayOfWeek);
// if ((Date.Month >= 1 && Date.Month < 3) || Date.Month == 12)
// {
//     Console.WriteLine("Winter");
// }
// else if (Date.Month >= 3 && Date.Month < 6)
// {
//     Console.WriteLine("Spring");
// }
// else if (Date.Month >= 6 && Date.Month < 9)
// {
//     Console.WriteLine("Summer");
// }
// else if (Date.Month >= 9 && Date.Month < 12)
// {
//     Console.WriteLine("Autumn");
// }

//____________________________________________

// Console.WriteLine("Enter the choice");
// Console.WriteLine("1. From F to C");
// Console.WriteLine("2. From C to F");
//
// int choice = Convert.ToInt32(Console.ReadLine());
//
// double temperature;
//
// if (choice == 1)
// {
//     Console.Write("Enter the temp in F: ");
//     temperature = Convert.ToDouble(Console.ReadLine());
//     double celsius = (temperature - 32) * 5 / 9;;
//     Console.WriteLine($"Temp in celsius: {celsius}°C");
// }
// else if (choice == 2)
// {
//     Console.Write("Enter the temp in C: ");
//     temperature = Convert.ToDouble(Console.ReadLine());
//     double fahrenheit = (temperature * 9 / 5) + 32;
//     Console.WriteLine($"Temp in farenheit: {fahrenheit}°F");
// }

//____________________________________________

// int num1,num2;
//
// Console.WriteLine("Enter the first number");
// num1 = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine("Enter the second number");
// num2 = Convert.ToInt32(Console.ReadLine());
//
// int tmp;
//
// if (num1 > num2)
// {
//     tmp = num1;
//     num1 = num2;
//     num2 = tmp;
// }
//
// for (int i = num1; i <= num2; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
// }