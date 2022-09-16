using System;
using System.Linq;
Console.WriteLine("Выберите номер задания которое хотите проверить: 54, 56, 58, 60 или 62");
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






switch (task)
{
    case 54:
        Console.Write("Введите колличество строк массива: ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите колличество столбцов массива: ");
        int col = Convert.ToInt32(Console.ReadLine());
        SortArray(row, col);
        break;
}

