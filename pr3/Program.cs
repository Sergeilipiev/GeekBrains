// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Задача 19
Console.WriteLine("Введите пятизначное число");
int digits = System.Convert.ToInt32(Console.ReadLine());
while (digits > 99999 || digits < 10000) {
    Console.WriteLine("Ошибка ввода. Введите пятизначное число");
    digits = System.Convert.ToInt32(Console.ReadLine());
}
int d1 = digits / 10000;
int d2 = digits / 1000 % 10;
int d4 = digits % 100 / 10;
int d5 = digits % 10;

if (d1 == d5 && d2 == d4) Console.WriteLine("Число палиндром");
else Console.WriteLine("Число не палиндром");

// Задача 21

Console.WriteLine("Введите координаты точки А");
string[] pointsA = Console.ReadLine().Split(' ',';',',');
Console.WriteLine("Введите координаты точки Б");
string[] pointsB = Console.ReadLine().Split(' ',';',',');

double d = Math.Sqrt((System.Convert.ToInt32(pointsB[0])-System.Convert.ToInt32(pointsA[0]))^2 
+ (System.Convert.ToInt32(pointsB[1])-System.Convert.ToInt32(pointsA[1]))^2 
+ (System.Convert.ToInt32(pointsB[2])-System.Convert.ToInt32(pointsA[2]))^2);
Console.WriteLine($"Расстояние равно {d}");

// Задача 23
Console.WriteLine("Введите число");
int digits2 = System.Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= digits2; i++) {
    Console.Write($"{Math.Pow (i, 3)}, ");
}
