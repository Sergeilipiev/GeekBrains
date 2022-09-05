// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Задача 25
int pow (int a, int b) {
    int s = a;
    for (int i = 0; i < b; i++)
    {
        s *= a;
    }
    return s;
}
Console.WriteLine("Введите возводимое число A");
int a = System.Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень B");
int b = System.Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A в натуральной степени B = {pow(a,b)}");

// Задача 27
int sum (int d) {
    int s = 0;
    do {
        s += d % 10;
        d /= 10;
    } while (d != 0);
    return s;
}
Console.WriteLine("Введите число");
int c = System.Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе = {sum(c)}");

// Задача 29
void newArr(int lenArr, int choose) {
    string[] arr = new string[lenArr];
    if (choose == 1) {
        Console.WriteLine($"Введите {lenArr} элементов массива через запятую");
        arr = Console.ReadLine().Split(',');
        Console.WriteLine(print(arr));
    }  else if (choose == 2) {
        Random rnd = new Random();
        for (int i = 0; i < lenArr; i++)
        {
           arr[i] = System.Convert.ToString(rnd.Next(0,10));
        }
        Console.WriteLine(print(arr));
    }
}

string print (string[] arr) {
    string str = System.Convert.ToString('[');
    for (int i = 0; i < arr.Length; i++)
    {
        str += arr[i];
        if (i != arr.Length - 1)
            str += ", ";
    }
    str += ']';
    return str;
}

Console.WriteLine("Введите 1, если хотите самостоятельно указать элементы массива");
Console.WriteLine("Введите 2, если хотите сгенерировать");
int choose = System.Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину массива");
int lenArr = System.Convert.ToInt32(Console.ReadLine());

newArr(lenArr,choose);
