// Напишите программу, которая на вход принимает координаты точки (x и y) причем они не равны нулю 
// и выдает номер четверти плоскости в которой находятся эти точки

// int FindQuart(int x, int y)
// {
//     if(x>0 && y>0)
//         return 1;
//     if(x<0 && y>0)
//         return 2;
//     if(x<0 && y<0)
//         return 3;
//     if(x>0 && y<0)
//         return 4;

//     return 0;

// }

// Console.WriteLine("Input x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Point locate at {FindQuart(x , y)} quart");

// Напишите программу которая принимает а вход координаты двух точек и находи расстояние между ними в 2D пространстве

// |

// Напишите программу которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y)

// void ShowRange(int quat)
// {
//     if(quat == 1) Console.WriteLine($"X range is (0, +inf), Y range is (0, +inf)");
//     if(quat == 2) Console.WriteLine($"X range is (0, -inf), Y range is (0, +inf)");
//     if(quat == 3) Console.WriteLine($"X range is (0, -inf), Y range is (0, -inf)");
//     if(quat == 4) Console.WriteLine($"X range is (0, +inf), Y range is (0, -inf)");
// }
// Console.WriteLine("Input the quater");
// int quad = Convert.ToInt32(Console.ReadLine());

// if(quad < 1 | quad > 5)
// {
//     Console.WriteLine("You input wrong number");
// }
// else
// {
//     ShowRange(quad);
// }

// Напишите программу,которая на вход ринимает число(N) и выдает квадраты чисел от 1 до N

// double Power(double digit)
// {
//     return Math.Pow(digit, 2);
// }
// Console.WriteLine("Input the number N: ");
// double N = Convert.ToDouble(Console.ReadLine());
// double i =1;
// while(i <= N)
// {
//     Console.WriteLine(Power(i));
//     i++;
// }

// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

 int GetNumber(string welcome)
{
    System.Console.Write(welcome);
    return Convert.ToInt32(Console.ReadLine());
}
int GetReverseInt(int n)
{
    int nRevers = 0;
    while( n > 0)
    {
    nRevers = nRevers * 10 + n % 10;
    n = n / 10;
    }
return nRevers;
}

int num = GetNumber(" Input number: ");
if(num == GetReverseInt(num))
{
    System.Console.WriteLine($" Your number {num} is poleondrom");
}
else
{
    System.Console.WriteLine($"Your number {num} is NOT poleondrom");
}




// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + 
//                                 Math.Pow(y2-y1, 2) +
//                                 Math.Pow(z2-z1, 2)), 2);
// }
// double GetNumber(string welcome)
// {
//     System.Console.Write(welcome);
//     return Convert.ToDouble(Console.ReadLine());
// }


// double x1 = GetNumber("input coordinate x1: ");
// double y1 = GetNumber("input coordinate y1: ");
// double z1 = GetNumber("input coordinate z1: ");
// double x2 = GetNumber("input coordinate x2: ");
// double y2 = GetNumber("input coordinate y2: ");
// double z2 = GetNumber("input coordinate z2: ");

// System.Console.WriteLine(FindDistance(x1 , y1 , z1 , x2 , y2 , z2));



// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// double Power(double digit)
// {
//     return Math.Pow(digit, 3);
// }
// Console.WriteLine("Input the number N: ");
// double N = Convert.ToDouble(Console.ReadLine());
// double i = 1;
// while(i <= N)
// {
//     Console.WriteLine(Power(i));
//     i++;
// }