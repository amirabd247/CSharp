// Console.WriteLine("Number Conversion Calculator");
// Console.WriteLine("Available number systems: 2 (binary), 10 (decimal), 16 (hexadecimal)");
// Console.WriteLine();
//
// while (true)
// {
//     Console.Write("Enter a number: ");
//     string inputNumber = Console.ReadLine();
//             
//     if (string.IsNullOrWhiteSpace(inputNumber))
//         break;
//
//     Console.Write("From base (2/10/16): ");
//     int fromBase = int.Parse(Console.ReadLine());
//
//     Console.Write("To base (2/10/16): ");
//     int toBase = int.Parse(Console.ReadLine());
//
//     try
//     {
//         string result = ConvertNumber(inputNumber, fromBase, toBase);
//         Console.WriteLine($"Result: {result}");
//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine($"Error: {ex.Message}");
//     }
//
//     Console.WriteLine();
// }
// static string ConvertNumber(string number, int fromBase, int toBase)
// {
//     int decimalNumber = Convert.ToInt32(number, fromBase);
//     return Convert.ToString(decimalNumber, toBase);
// }


// Console.WriteLine("Enter a word (zero to nine):");
// string userInput = Console.ReadLine().ToLower();
//
// string digit;
//
// if (userInput == "zero")
// {
//     digit = "0";
// }
// else if (userInput == "one")
// {
//     digit = "1";
// }
// else if (userInput == "two")
// {
//     digit = "2";
// }
// else if (userInput == "three")
// {
//     digit = "3";
// }
// else if (userInput == "four")
// {
//     digit = "4";
// }
// else if (userInput == "five")
// {
//     digit = "5";
// }
// else if (userInput == "six")
// {
//     digit = "6";
// }
// else if (userInput == "seven")
// {
//     digit = "7";
// }
// else if (userInput == "eight")
// {
//     digit = "8";
// }
// else if (userInput == "nine")
// {
//     digit = "9";
// }
// else
// {
//     digit = "Invalid input";
// }
//
// Console.WriteLine($"The digit is: {digit}");





// try
// {
//     Passport passport = new Passport("AB123456", "John Doe", new DateTime(2020, 10, 15));
//     Console.WriteLine($"Passport {passport.PassportNumber} issued to {passport.FullName} on {passport.IssueDate:dd.MM.yyyy}");
// }
// catch (ArgumentException ex)
// {
//     Console.WriteLine($"Error: {ex.Message}");
// }
// class Passport
// {
//     private string passportNumber;
//     private string fullName;
//     private DateTime issueDate;
//     
//     public Passport(string passportNumber, string fullName, DateTime issueDate)
//     {
//         if (string.IsNullOrWhiteSpace(passportNumber))
//             throw new ArgumentException("Passport number cannot be empty or contain only spaces.");
//
//         if (string.IsNullOrWhiteSpace(fullName))
//             throw new ArgumentException("Owner's full name cannot be empty or contain only spaces.");
//
//         if (issueDate > DateTime.Now)
//             throw new ArgumentException("Issue date cannot be in the future.");
//
//         this.passportNumber = passportNumber;
//         this.fullName = fullName;
//         this.issueDate = issueDate;
//     }
//     
//     public string PassportNumber
//     {
//         get { return passportNumber; }
//     }
//
//     public string FullName
//     {
//         get { return fullName; }
//     }
//
//     public DateTime IssueDate
//     {
//         get { return issueDate; }
//     }
// }



// try
// {
//     Console.WriteLine("Enter a logical expression (e.g., 3>2 or 7<3):");
//     string input = Console.ReadLine();
//
//     bool result = EvaluateExpression(input);
//
//     Console.WriteLine($"Result: {result}");
// }
// catch (FormatException)
// {
//     Console.WriteLine("Error: Invalid input format.");
// }
// catch (ArgumentException ex)
// {
//     Console.WriteLine($"Error: {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Error: {ex.Message}");
// }
//
// static bool EvaluateExpression(string input)
// {
//     string[] operators = { "<", ">", "<=", ">=", "==", "!=" };
//
//     foreach (string op in operators)
//     {
//         if (input.Contains(op))
//         {
//             string[] parts = input.Split(new[] { op }, StringSplitOptions.RemoveEmptyEntries);
//
//             if (parts.Length != 2)
//             {
//                 throw new ArgumentException("Error: Invalid input format.");
//             }
//
//             int leftOperand = int.Parse(parts[0]);
//             int rightOperand = int.Parse(parts[1]);
//
//             switch (op)
//             {
//                 case "<":
//                     return leftOperand < rightOperand;
//                 case ">":
//                     return leftOperand > rightOperand;
//                 case "<=":
//                     return leftOperand <= rightOperand;
//                 case ">=":
//                     return leftOperand >= rightOperand;
//                 case "==":
//                     return leftOperand == rightOperand;
//                 case "!=":
//                     return leftOperand != rightOperand;
//             }
//         }
//     }
//
//     throw new ArgumentException("Error.");
// }