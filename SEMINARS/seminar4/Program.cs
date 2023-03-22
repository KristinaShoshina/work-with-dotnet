// Напишите программу которая на вход принимает число А и показывает сумму чисел от 1 до А

// int FindSum(int num)
// {
//     int sum = 0;
//     for (int current = 1; current <= num; current ++)
//     {
//         sum+=current;     
//     }
//     return sum;
// }
// Console.WriteLine("Input A");
// int A =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindSum (A));

// Напишите программу которая выводит массив из 8 элементов заполненный нулями и единицами в рандомном порядке

// int[]CreatRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//     newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
// }

// void ShowArray(int [] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input minimal value: ");
// int minValue=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value: ");
// int maxValue=Convert.ToInt32(Console.ReadLine());

// ShowArray(CreatRandomArray(size, minValue, maxValue));

// Напишите программу которая принимает на вход число и выдает кол-во цифр в числе



// Console.WriteLine("Input number A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// while(A > 0)
// {
//     A = A / 10;
//     count ++;
// }
// Console.WriteLine($"In number {count} digits");







// int FindNumbers(int num)
// {
// int count = 0;
// while (num > 0)
//     {

//         num = num / 10;
//         count = count + 1;
//     }
//     return count;
// }
// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"This number is {FindNumbers(num)} digits");


// Напишите программу которая принимает на вход число n и возвращает произведение чисел от 1 до n(n!)

// int Facto(int num)
// {
//     int result = 1;
//     for (int i = 1; i <= num; i++)
//     result = result * i; 
//     return result;
// }
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"factorial of number {num} is {Facto(num)}.");    

// ДЗЗЗЗ


// напишите цикл, который принимает на вход два числа(A,B) И возводит число А в натуральную степень B

// int GetNumber(string welcome)
// {
//     Console.Write(welcome);
//     int x = Convert.ToInt32(Console.ReadLine());
//     return x;
// }

// int A = GetNumber("Input A: ");
// int B = GetNumber("Input B: ");
// int sum = 1;
// if (B < 0)
// {
//     B = -B;
// }
// while (B > 0)
// {
//     sum = A * sum;
//     B = B - 1;
// }

// Console.Write(sum);

// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе

// int GetNumber(string welcome)
// {
//     Console.Write(welcome);
//     int x = Convert.ToInt32(Console.ReadLine());
//     return x;
// }
// int A = GetNumber("Input number: ");                
// int sum = 0;
// while (A > 0)
// {                              
//     sum = sum + A % 10;         
//     A = A / 10;                                
// }
// Console.Write(sum);




// Напишите программу, которая задает массив из 8 элементов и выводит их на экран

// int[]array = new int[8];       //создали массив из 8 элементов

// void FillArray(int[]collection)          
// {
//     for (int i = 0; i < collection.Length; i++)
//     {
//                                                        //шаг 3 функция, тело функции
//         collection[i] = new Random().Next(1,8);

//     }
// }

// FillArray(array);                   //шаг 2 вызвать функцию

// void PrintArray(int[]arr)                    
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i]  +  " ");
//     }
// }
// PrintArray(array);

// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//     newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
// }

