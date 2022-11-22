// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5   7   -2   -0,2
// 1    -3,3  8   -9,9
// 8     7,8 -7,1  9

// double[,] Create2dArray(int rows, int columns)
// {
//     double[,] matrix = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = Math.Round(new Random().NextDouble() * 10 - 3.2, 1);
//         }

//     }
//     return matrix;
// }
// void Show2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] created2dArray = Create2dArray(rows, columns);
// Show2dArray(created2dArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] Create2dArray(int rows, int columns)
// {
//     int[,] createdArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             createdArray[i, j] = new Random().Next(-100, 101);
//         }
//     }
//     return createdArray;
// }
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// bool CheckingNumber(int number, int[,] checkingArray)
// {
//     for (int i = 0; i < checkingArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < checkingArray.GetLength(1); j++)
//         {
//             if (checkingArray[i, j] == number)
//             {
//                 return true;
//             }
//         }
//     }
//     return false;
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = Create2dArray(rows, columns);
// Show2dArray(matrix);
// System.Console.WriteLine("\nPlese input a number to check");
// int checkedNumber = Convert.ToInt32(Console.ReadLine());
// bool chekedResult = CheckingNumber(checkedNumber, matrix);
// if (chekedResult == true)
// {
//     System.Console.WriteLine(checkedNumber + " is inside the array");
// }
// else {
//     System.Console.WriteLine(checkedNumber + " isn't inside the array");
// }

// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Create2dArray(int rows, int columns)
{
    int[,] createdArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            createdArray[i, j] = new Random().Next(0, 10);
        }
    }
    return createdArray;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

double[] FindAverage(int[,] array)
{
    double [] avrge = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avrge[j] += array[i, j];
        }
        avrge[j] /=array.GetLength(0);
        System.Console.WriteLine($"The average of the {j+1} is {avrge[j]}; ");
    }
    return avrge;
}

System.Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = Create2dArray(rows, columns);
Show2dArray(matrix);
FindAverage(matrix);