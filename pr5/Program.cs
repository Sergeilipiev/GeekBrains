// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Задача 34
int[] CreateArray (int len, int min, int max) {
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
        arr[i] = new Random().Next(min, max + 1);
    return arr;
}

int EvenInArray (int[] arr) {
    int countEven = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] % 2 == 0) countEven++;
    }
    return countEven;
}

void PrintArray (int[] arr) {
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] arr = CreateArray(20, 100, 999);

// PrintArray(arr);
// Console.WriteLine($"Количество четных элементов = {EvenInArray(arr)}");

// Задача 36

int[] arr2 = CreateArray(20, -100, 100);

int SumEvenElements (int[] arr) {
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != 0 || i % 2 == 0)
            sum += arr[i];
    }
    return sum;
}

// PrintArray(arr2);
// Console.WriteLine($"Сумма четных элементов массива = {SumEvenElements(arr2)}");

// Задача 38
double[] CreateArray2 (int len, int min, int max) {
    double[] arr = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
        arr[i] = Math.Round(rnd.Next(min,max) + rnd.NextDouble(), 2);
    return arr;
}
double[] arr3 = CreateArray2(20, 1, 99);

double DiffMinMax (double[] arr, double min = 0, double max = 99) {
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max =  arr[i];
        if (arr[i] < min) min =  arr[i];
    }
    return max - min;
}

void PrintArray2 (double[] arr) {
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

Console.WriteLine(PrintArray2(arr3));
// Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {DiffMinMax(arr3, 1, 99)}");




