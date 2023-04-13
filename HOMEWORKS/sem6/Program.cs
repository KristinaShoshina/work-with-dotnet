// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// void Main()

// {
//     Console.Write("Please Input array size: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] randomArr = GetArray(size);
//     PrintArray(randomArr);
//     System.Console.WriteLine($"Positive numbers is {CountPositive(randomArr)} count");

// }

// Main();

// int[] GetArray(int size)
// {
//     int[] randomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"Input {i + 1} elements: ");
//         randomArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return randomArray;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
// }

// int CountPositive(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;

//     }
//     return count;
// }












// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

 

// double GetNumber(string welcome)
// {
//     Console.Write(welcome);
//     return Convert.ToDouble(Console.ReadLine());
// }

// void Main()
// {


// double k1 = GetNumber("Input k1: ");                
// double b1 = GetNumber("Input b1: ");                
// double k2 = GetNumber("Input k2: ");                
// double b2 = GetNumber("Input b2: ");   
// double x = 0 ;            
// double y = 0 ;  
// if(k1 == k2 && b1 == b2)
// {
//     Console.Write("These lines match");
// }
// else if (k1 == k2)
// {
//     Console.Write("These lines are parallel");
// }
// else 
// {
//      x= (b2-b1)/(k1-k2);
//      y = k1*x+b1;

// }
// Console.Write($"x coordinate is {x}, y coordinate is {y}");

// // Если k1 = k2 прямые не пересукутся 
// // иначе - ищем по формуле x = (b2-b1)/(k1-k2);
// //                         y =  k1 * x + b1   
// }
// Main();



// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// string Allnumbers(int N)
// {
//     if (N == 1)
//     {
//         return "1";
//     }
//     return N.ToString() + " ," + Allnumbers(N-1);
// }
// void Main()
// {
//     System.Console.WriteLine(Allnumbers(5));
// }
// Main();

// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов
//  в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int Sum(int N, int M)
// {
//     if (N == M) return M;
//     return N + Sum(N + 1, M);
// }
// void Main()
// {
//     System.Console.WriteLine(Sum(1, 15));
// }
// Main();

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int ack(int n, int m)
// {
//     if (n == 0)
//         return m + 1;
//     if (m == 0)
//         return ack (n - 1, 1);
//     else
//         return ack(n - 1, ack (n, m - 1));
// }
// void Main()
// {
// System.Console.WriteLine("Input n");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input m");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(ack(n,m));
// }
// Main();