// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] GenArr2D (int row, int col, int min, int max) {
    int [,] arr = new int [row,col];
    for (int i = 0; i < row; i++) 
        for (int j = 0; j < col; j++)
            arr[i,j] = new Random().Next(min,max+1);
    return arr;
}
double [,] GenArr2DDouble (int row, int col, int min, int max) {
    double [,] arr = new double [row,col];
    for (int i = 0; i < row; i++) 
        for (int j = 0; j < col; j++)
            arr[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
    return arr;
}

void PrintArr2D (int [,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) 
            System.Console.Write($"{arr[i,j]}\t");    
        System.Console.WriteLine();           
    }
}

void PrintArr2DDouble (double [,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) 
            System.Console.Write($"{arr[i,j]}\t");    
        System.Console.WriteLine();           
    }
}

void PrintArray (double[] arr) {
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

// Задача 47
int m = 3;
int n = 4;

PrintArr2DDouble(GenArr2DDouble(m,n,1,9));



// Задача 50
Console.WriteLine($"Введите позицию элемента в двумерном массиве");
string[] strArr = Console.ReadLine().Split(',',' ','.');
int [,] arr2D = GenArr2D(5,5,1,9);
PrintArr2D(arr2D);
getElement2D(arr2D, strArr);

void getElement2D (int[,] arr, string[] strArr) {
    if (strArr.Length == 2)
        {
            int[] arr2 = new int [strArr.Length]; 
            for (int i = 0; i < strArr.Length; i++)
                {
                    arr2[i] = System.Convert.ToInt32(strArr[i]);
                }
            if (arr[arr2[0],arr2[1]].GetType()  == typeof(int)) {
                  Console.WriteLine($"Элемент в двумерном массиве: {arr[arr2[0],arr2[1]]}");  
            } else {
                Console.WriteLine($"{arr2[0]},{arr2[1]} -> такого числа в массиве нет");  
            }
        } else 
        {
            Console.WriteLine($"Введите 2 цифры позиции элемента в двумерном массиве");
        }
}

// Задача 52
int [,] arr2D2 = GenArr2D(3,3,1,9);
PrintArr2D(arr2D2);

double[] arrSum = new double[arr2D2.GetLength(0)];
for (int i = 0; i < arr2D2.GetLength(1); i++)
{
    double sumCol = 0;
    for (int j = 0; j < arr2D2.GetLength(0); j++)
    {
        sumCol+=arr2D2[j,i];
    }
    arrSum[i] = sumCol / arr2D2.GetLength(0);
}
PrintArray(arrSum);
