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





void Main()

{
   Console.Write("Please Input array size: ");
   int size = Convert.ToInt32(Console.ReadLine());
   int[] randomArr = GetArray(size);
   PrintArray(randomArr);
   System.Console.WriteLine("--> " + GetNumber(randomArr));
 }

 Main();

 int[] GetArray(int size)
 {
     int[] randomArray = new int[size];
     for (int i = 0; i < size; i++)
     {
         randomArray[i] = new Random().Next(100, 1000);
     }
     return randomArray;
 }

 void PrintArray(int[] arr)
 {
     for (int i = 0; i < arr.Length; i++)
     {
         Console.Write(arr[i] + " ");
     }
 }


int GetSUMM(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+= 2)
    {
        sum = sum + arr[i] ; 
    }
    return sum;
}