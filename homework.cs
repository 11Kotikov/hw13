// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5   7   -2   -0,2
// 1    -3,3  8   -9,9
// 8     7,8 -7,1  9

double[,] Create2dArray(int rows, int columns, int minValue, int maxvalue)
{
    double[,] createdArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            createdArray[i, j] = new Random().Next(minValue, maxvalue + 1);
        }
    }
    return createdArray;
}
void Show2dArray(double[,] array)
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

System.Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double [,] created2dArray = Create2dArray(rows, columns, minValue, maxValue);
Show2dArray (created2dArray);