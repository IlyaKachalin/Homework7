// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

try
{
    Console.Write("Введите позиции искомого элемента. Rows = ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Columns = ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Random rnd = new Random();

    int[,] FillMatrix(int rows, int columns, int min_value, int max_value)
    {
        int[,] matrix = new int[rows, columns];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rnd.Next(min_value, max_value + 1);
            }
        }
        return matrix;
    }

    void PrintMatrix(int[,] matrix)
    {

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("[");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},  ");
                else Console.Write($"{matrix[i, j],3}");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }

    string CheckPosition(int rows, int positions, int[,] matrix)
    {
        string result = string.Empty;

        if (rows >= 0 && rows < matrix.GetLength(0) && columns >= 0 && columns < matrix.GetLength(1)) Console.WriteLine(matrix[rows, columns]);
        else Console.WriteLine("Элемента с указанными позициями не существует");

        return result;
    }

    int[,] result = FillMatrix(3, 4, 1, 9);
    PrintMatrix(result);
    string result1 = CheckPosition(rows, columns, result);
    Console.WriteLine($"{result}");

}

catch
{
    Console.WriteLine("Вводить нужно было целые числа");
}