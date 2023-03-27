// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2 
// размер массива задаём сами 

// void Main()
// {
//     Console.Write("Please Input array size: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] randomArr = GetArray(size);
//     PrintArray(randomArr);
//     System.Console.WriteLine("--> " + GetNumber(randomArr));
// }

// Main();

// int[] GetArray(int size)
// {
//     int[] randomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         randomArray[i] = new Random().Next(100, 1000);
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

// int GetNumber(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0) count++;
//     }
//     return count;
// }


// Задача 36.Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов,стоящих на нечетной позиции


// void Main()

// {
//    Console.Write("Please Input array size: ");
//    int size = Convert.ToInt32(Console.ReadLine());
//    int[] randomArr = GetArray(size);
//    PrintArray(randomArr);
//    System.Console.WriteLine("--> " + GetNumber(randomArr));
//  }

//  Main();

//  int[] GetArray(int size)
//  {
//      int[] randomArray = new int[size];
//      for (int i = 0; i < size; i++)
//      {
//          randomArray[i] = new Random().Next(100, 1000);
//      }
//      return randomArray;
//  }

//  void PrintArray(int[] arr)
//  {
//      for (int i = 0; i < arr.Length; i++)
//      {
//          Console.Write(arr[i] + " ");
//      }
//  }


// int GetSUMM(int[] arr)
// {
//     int sum = 0;
//     for (int i = 1; i < arr.Length; i+= 2)
//     {
//         sum = sum + arr[i] ; 
//     }
//     return sum;
// }

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// void Main()
// {
//     Console.Write("Please Input array size: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     double[] randomArr = GetArray(size);
//     PrintArray(randomArr);
//     Dif(randomArr);
//     // System.Console.WriteLine("--> " + GetNumber(randomArr));
// }

// Main();

// double[] GetArray(int size)
// {
//     double[] randomArray = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         randomArray[i] = Math.Round(new Random().Next(1, 1000) + new Random().NextDouble(), 3);
//         ///                               254,413253244215
//     }
//     return randomArray;
// }

// void PrintArray(double[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
// }

// void Dif(double[] array)
// {
//     double min = array[0];
//     double max = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] > max) { max = array[i]; }
//         if (array[i] < min) { min = array[i]; }
//     }
//     Console.Write($"\nminimum number is {min} and maximum number is {max}\ndifference is {max - min}");
// }
