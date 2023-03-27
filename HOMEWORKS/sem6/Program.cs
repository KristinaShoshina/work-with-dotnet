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
