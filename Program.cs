// Задача 1: Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23
// a=50 => нет
// a=7 => нет
// a=322 => да

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// n = Math.Abs(n);
// if (n%7==0 || n%23==0){
//     Console.WriteLine($"Число {n} кратно 7 и 23");
// }
// else{
//     Console.WriteLine($"Число {n} не кратно 7 и 23");
// }

// Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.
// 2, 3 => 1
// -5, 3 => 2
// -3, -2 => 3
// 4, -2 => 4

// using System.IO.Compression;

// Console.Clear();
// Console.Write("Введите координату X: ");
// int x = int.Parse(Console.ReadLine()!);
// while (x==0){
//     Console.Write("Ошибка! X не должен быть равен 0! \nВведите координату X: ");
//     x = int.Parse(Console.ReadLine()!);
// }
// Console.Write("Введите координату Y: ");
// int y = int.Parse(Console.ReadLine()!);
// int z=0;
// while (y==0){
//     Console.Write("Ошибка! Y не долженбыть равен 0! \nВведите координату Y: ");
//     y = int.Parse(Console.ReadLine()!);
// }
// if (x>0 && y>0){
//     z=1;
// }
// else if (x<0 && y>0){
//     z=2;
// }
// else if (x<0 && y<0){
//     z=3;
// }
// else if (x>0 && y<0){
//     z=4;
// }
// Console.WriteLine($"При координатах точки X={x} и Y={y} она относится к {z}-ой координатной четверти плоскости!");

// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 40 => 4
// 96 => 9
// 72 => 7

// Console.Clear();
// Console.Write("Введите целое число от 10 до 99: ");
// int x = int.Parse(Console.ReadLine()!);
// while (x<10||x>99){
//     Console.Write("Ошибка! Введенное число не входит в заданный отрезак! \nВведите целое число от 10 до 99: ");
//     x = int.Parse(Console.ReadLine()!);
// }
// int x1=x/10;
// int x2=x%10;
// if (x1>x2){
//     Console.WriteLine($"{x1}");
// }
// else {
//     Console.WriteLine($"{x2}");
// }

// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.
// 568 => 5,6,8
// 8 => 8
// 9542 => 9,5,4,2

Console.Clear();
Console.Write("Введите натуральное число: ");
int x = int.Parse(Console.ReadLine()!);
int y = x.ToString().Length;
int result = 0;
while (x > 0)
            {
                result *= 10;
                result += x % 10;
                x /= 10;
            }
 
            for (int i = 0; i < y; i++)
            {
                Console.Write(result%10+ ",");
                result /= 10;
            }
 
        
