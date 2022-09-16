Console.Clear();
Console.WriteLine("Выберите номер задания которое хотите проверить: 54, 56 или 58");
int task = Convert.ToInt32(Console.ReadLine());


void SortArray(int row, int col)
{
    var matrix = new int[row, col];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    var arr = matrix.Cast<int>().OrderByDescending(a => a).ToArray();

    int c = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            matrix[j, k] = arr[c];
            Console.Write(matrix[j, k] + " ");
            c++;
        }
        Console.WriteLine();
    }
}


int[,] CreateMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],1}|");
            else Console.Write($"{matrix[i, j],1}");
        }
        Console.WriteLine("|");
    }
}

static void SumStringMatrix(int[,] matrix)
{
    int index = 0, minsum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    string line = string.Empty;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        line += matrix[index, j] + " ";
    }
    Console.WriteLine($"Строка с минимальной суммой элементов равна {line}. ");
}

Random rnd = new Random();
int[,] CreateMatrixTwo(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrixTwo(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],1}|");
            else Console.Write($"{matrix[i, j],1}");
        }
        Console.WriteLine("|");
    }
}
int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}


switch (task)
{
    case 54:
        Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
        Console.Write("Введите колличество строк массива: ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите колличество столбцов массива: ");
        int col = Convert.ToInt32(Console.ReadLine());
        SortArray(row, col);
        break;
    case 56:
        Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей сумм.");
        Console.Write("Введите колличество строк массива: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите колличество столбцов массива: ");
        int y = Convert.ToInt32(Console.ReadLine());
        int[,] array2D = CreateMatrix(x, y);
        PrintMatrix(array2D);
        SumStringMatrix(array2D);
        break;
    case 58:
        Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
        int[,] array2DTwo = CreateMatrixTwo(rnd.Next(2, 4), rnd.Next(2, 4), 0, 9);
        int[,] matrix = CreateMatrixTwo(rnd.Next(2, 4), rnd.Next(2, 4), 0, 9);
        PrintMatrixTwo(array2DTwo);
        Console.WriteLine();
        PrintMatrixTwo(matrix);
        Console.WriteLine();
        PrintMatrixTwo(DivMatrix(array2DTwo, matrix));












        break;
}

