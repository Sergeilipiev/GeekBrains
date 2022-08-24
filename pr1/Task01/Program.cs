//----Задача 2----
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) {
    Console.WriteLine("Первое число больше");
} else {
    Console.WriteLine("Второе число больше");
}

//----Задача 4----

Console.WriteLine("Введите первое число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int z = Convert.ToInt32(Console.ReadLine());

int max = x;
if (y > max) max = y;
if (z > max) max = z;

Console.WriteLine($"Большее число {max}");

//----Задача 6----

Console.WriteLine("Введите число");
int s = Convert.ToInt32(Console.ReadLine());
int t = s % 2;
if (t == 0) Console.WriteLine("Делится");
else Console.WriteLine("Не делится");

//----Задача 8----

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++) {
    if (i % 2 == 0) Console.Write($"{i} ");
}
