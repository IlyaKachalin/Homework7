// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

double[,] FillMatrix(int rows, int columns, double min_value, double max_value)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            double num = rnd.NextDouble() * 100;
            matrix[i, j] = Math.Round(num, 2);

        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},  ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

Console.Write("Введите минимальное значение матричного аргумента. min = ");
double min_value = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите максимальное значение матричного аргумента. max = ");
double max_value = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите количество строк. rows = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов. columns = ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[rows, columns];

double[,] result = FillMatrix(rows, columns, min_value, max_value);
Console.WriteLine(result);
PrintMatrix(result);
