// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("input three-digit number");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num>= 100 && num <= 999)
// {
//     int dec = num / 10;
//     int num2 = dec % 10;
//     Console.WriteLine($"Second digit is {num2}");
// }
// else
// {
//     Console.WriteLine($"You input wrong number");
// }

//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.WriteLine("Input number");
// int num =Convert.ToInt32(Console.ReadLine());
// if(num>99)
// {
//         int temp = num;
//         while (temp > 999)
//         {
//             temp = temp / 10;
//         }
//         Console.WriteLine($"Third digit of {num} is {temp % 10}");
// }
// else
// {
//     Console.WriteLine("Third digit doesnt exist");
// }
 

//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Input day of the week");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num>5 && num<8)
// {
//     Console.WriteLine($"Yaaaay! It's weekend");
// }
// if(num<5)
// {
//     Console.WriteLine("Oh no! You have to work");
// }
// if(num>=8)
// {
//     Console.WriteLine($"This day doesnt exist");
// }