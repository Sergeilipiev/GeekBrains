//Задача 10
Console.WriteLine("Введите трехзначное число");
int digits = System.Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Второе число = {digits / 10 % 10}");

// Задача 13
Console.WriteLine("Введите число");
string str = Console.ReadLine()!;
int len = str.Length;
if (len <= 2)
    Console.WriteLine("Третей цифры нет");
else 
    Console.WriteLine($"Третяя цифра {str[2]}");

// Задача 15
Console.WriteLine("Введите цифру, обозначающую день недели 1-7");
int day = System.Convert.ToInt32(Console.ReadLine());
if (day > 7 || day < 1) {
    Console.WriteLine("Такого дня недели не существует");
} else if (day > 5) {
    Console.WriteLine("Да");
} else {
    Console.WriteLine("Нет");
}