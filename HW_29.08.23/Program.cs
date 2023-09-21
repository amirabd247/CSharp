using System.Threading.Channels;
//
// int[] arr1 = new int[5];
// int[,] arr2 = new int[3,4];
//
// Random value = new Random();
//
// for (int i = 0; i < arr1.Length; i++)
// {
//     Console.WriteLine("Enter the number");
//     int number = Convert.ToInt32(Console.ReadLine());
//     arr1[i] = number;
// }
//
//
// for (int i = 0; i < arr2.GetLength(0); i++)
// {
//     for (int j = 0; j < arr2.GetLength(1); j++)
//     {
//         arr2[i, j] = value.Next(1,10);
//     }
// }
//
// foreach (var item in arr1)
// {
//     Console.Write($"{item} ");
// }
//
// Console.WriteLine();
// Console.WriteLine();
//
// for (int i = 0; i < arr2.GetLength(0); i++)
// {
//     for (int j = 0; j < arr2.GetLength(1); j++)
//     {
//         Console.Write($"{arr2[i,j]} ");
//     }
//     Console.WriteLine();
// }
//
// List<int> same = new List<int>();
//
// for (int i = 0; i < arr1.Length; i++)
// {
//     for (int j = 0; j < arr2.GetLength(0); j++)
//     {
//         for (int k = 0; k < arr2.GetLength(1); k++)
//         {
//             if (arr1[i] == arr2[j, k])
//             {
//                 same.Add(arr2[j,k]);
//                 continue;
//             }
//         }
//     }
// }
//
// Console.WriteLine();
//
// int max = 0;
//
// for (int i = 0; i < same.Count; i++)
// {
//     if (same[i] > max)
//     {
//         max = same[i];
//     }
// }
//
// int min = max;
//
// for (int i = 0; i < same.Count; i++)
// {
//     if (same[i] < min)
//     {
//         min = same[i];
//     }
// }
//
// Console.WriteLine($"The max general value :{max}");
// Console.WriteLine($"The min general value :{min}");
//
// int summ = 0;
// int mult = 1;
// int evensumm = 0;
// int oddmatrixsumm = 0;
//
//
// foreach (var item in same)
// {
//     summ += item;
// }
//
// foreach (var item in same)
// {
//     mult *= item;
// }
//
// foreach (var item in arr1)
// {
//     if (item % 2 == 0)
//     {
//         evensumm += item;
//     }
// }
//
// for (int i = 0; i < arr2.GetLength(0); i++)
// {
//     for (int j = 0; j < arr2.GetLength(1); j++)
//     {
//         if (j % 2 != 0)
//         {
//             oddmatrixsumm += arr2[i, j];
//         }
//     }
// }
//
// Console.WriteLine($"The general summ :{summ}");
// Console.WriteLine($"The general product :{mult}");
// Console.WriteLine($"The summ of array's even values  :{evensumm}");
// Console.WriteLine($"The summ of matrix's odd colums values :{oddmatrixsumm}");



// Random value = new Random();
// int[,] arr = new int[5,5];
//
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = value.Next(-100, 100);
//     }
// }
//
//
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         Console.Write($"{arr[i,j] } ");
//     }
//
//     Console.WriteLine();
// }
//
// int max = -101;
// int indexmaxX = new int();
// int indexmaxY = new int();
// int min = 101;
// int indexminX = new int();
// int indexminY = new int();
//
// for (int j = 0; j < arr.GetLength(0); j++)
// {
//     for (int i = 0; i < arr.GetLength(1); i++)
//     {
//         if (arr[j,i] > max)
//         {
//             max = arr[j,i];
//             indexmaxX = j;
//             indexmaxY = i;
//         }
//
//         if (arr[j,i] < min)
//         {
//             min = arr[j,i];
//             indexminX = j;
//             indexminY = i;
//         }
//     }
// }
//
// int summ = 0;
//
// if (indexmaxX > indexminX)
// {
//     for (int i = indexminX; i < indexmaxX; i++)
//     {
//         for (int j = indexminY; j < indexmaxY; j++)
//         {
//             summ += arr[i, j];
//         }
//     }
// }
// else if (indexmaxX < indexminX)
// {
//     for (int i = indexmaxX; i < indexminX; i++)
//     {
//         for (int j = indexmaxY; j < indexminY; j++)
//         {
//             summ += arr[i, j];
//         }
//     }
// }
// else if (indexmaxX == indexminX && indexmaxY > indexminY)
// {
//     for (int j = indexminY; j < indexmaxY; j++)
//     {
//         summ += arr[indexmaxY, j];
//     }
// }
// else if (indexmaxX == indexminX && indexmaxY < indexminY)
// {
//     for (int j = indexmaxY; j < indexminY; j++)
//     {
//         summ += arr[indexmaxY, j];
//     }
// }
//
// Console.WriteLine(max);
// Console.WriteLine(min);
// Console.WriteLine(summ);


// string word;
//
// word = "PDN";
//
// Console.WriteLine("Enter the number of shift");
// int key = Convert.ToInt32(Console.ReadLine());
//
// List<char> lettersList = new List<char>();
//
// foreach (char item in word)
// {
//     lettersList.Add(item);
// }
//
// Console.WriteLine("Enter the choice 1.Encrypt 2.Decrypt");
// int choice;
// choice = Convert.ToInt32(Console.ReadLine());
//
// if (choice == 1)
// {
//     for (int i = 0; i < word.Length; i++)
//     {
//         char baseChar = Char.IsUpper(lettersList[i]) ? 'A' : 'a';
//         lettersList[i] = (char)(baseChar + (lettersList[i] - baseChar + key) % 26);
//     }
//
//     foreach (var item in lettersList)
//     {
//         Console.Write(item);
//     }
// }
// else if (choice == 2)
// {
//     for (int i = 0; i < word.Length; i++)
//     {
//         char baseChar = Char.IsUpper(lettersList[i]) ? 'A' : 'a';
//         lettersList[i] = (char)(baseChar + (lettersList[i] - baseChar - key )% 26);
//     }
//     foreach (var item in lettersList)
//     {
//         Console.Write(item);
//     }
// }

// int[,] matrix = new int[3, 3];
//
// Random value = new Random();
//
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = value.Next(1, 10);
//     }
// }
//
// int mult = 1;
// int summ = 0;
//
// Console.WriteLine("Enter the number");
// int number = Convert.ToInt32(Console.ReadLine());
//
//
//
// foreach (var item in matrix)
// {
//     mult *= item;
// }
// foreach (var item in matrix)
// {
//     summ += item;
// }
//
// number = summ * number;
//
//
// Console.WriteLine($"The multiplication of matrix on number is {number}");
// Console.WriteLine($"The product of matrix {mult}");
// Console.WriteLine($"The sum of matrix {summ}");


// string data = "";
// Console.WriteLine("Enter the example (exm: 3+44-5");
// data = Console.ReadLine();
// string operation = "";
// char current;
//
// int num = 0;
// int num2 = 0;
// int currentint;
// for (int i = 0; i < data.Length; i++)
// {
//     current = data[i];
//     currentint = 0;
//     if (char.IsDigit(current) && string.IsNullOrEmpty(operation))
//     {
//         currentint = int.Parse(current.ToString());
//         num = num * 10 + currentint;
//     }
//     else if (char.IsDigit(current) && !(string.IsNullOrEmpty(operation)))
//     {
//         currentint = int.Parse(current.ToString());
//         num2 = num2 * 10 + currentint;
//     }
//     else if (!(char.IsDigit(current)) && string.IsNullOrEmpty(operation))
//     {
//         if (current == '+')
//         {
//             operation = "+";
//         }
//         else
//         {
//             operation = "-";
//         }
//     }
//     else if (!(char.IsDigit(current)) && !(string.IsNullOrEmpty(operation)))
//     {
//         if (operation == "+")
//         {
//             num += num2;
//             num2 = 0;
//         }
//         else if (operation == "-")
//         {
//             num -= num2;
//             num2 = 0;
//         }
//         if (current == '+')
//         {
//             operation = "+";
//         }
//         else
//         {
//             operation = "-";
//         }
//     }
//
//     if (i == data.Length - 1)
//     {
//         if (operation == "+")
//         {
//             num += num2;
//         }
//         else if (operation == "-")
//         {
//             num -= num2;
//         }
//     }
//     
// }
//
// Console.WriteLine(num);
//     



// string text = "today is a good day for walking. i will try to walk near the sea";
//
// text = text.Replace(". ", ".");
// char[] separators = new char[] { '.', '?', '!' };
// string[] sentences = text.Split(separators);
//
// for (int i = 0; i < sentences.Length; i++)
// {
//     sentences[i] = char.ToUpper(sentences[i][0]) + sentences[i].Substring(1);
// }
//
//
// foreach (string line in sentences)
// {
//         Console.Write(line);
//         Console.Write(".");
// }

// string text = @"To be, or not to be, that is the question,
//                 Whether 'tis nobler in the mind to suffer
//                 The slings and arrows of outrageous fortune,
//                 Or to take arms against a sea of troubles,
//                 And by opposing end them? To die: to sleep;
//                 No more; and by a sleep to say we end
//                 The heart-ache and the thousand natural shocks
//                 That flesh is heir to, 'tis a consummation
//                 Devoutly to be wish'd. To die, to sleep";
//                 
//                 
// string keyword = "to";
// string censored = new string('*', keyword.Length);
//
// string result = text.Replace(keyword, censored, StringComparison.OrdinalIgnoreCase);
//
// Console.WriteLine(result);