Console.Clear();
Console.WriteLine("Введите номер задания, которое хотите проверить: 47, 50 или 52.");
int task = Convert.ToInt32(Console.ReadLine());

void taskOne(int m, int n)
{
    double[,] array = new double[m, n];
    Random rand = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rand.Next(-100, 100) * rand.NextDouble();
            Console.Write("{0,9:F2}", array[i, j]);
        }
        Console.WriteLine();
    }
}

void taskTwo(int x, int y)
{
    int[,] array = new int[x, y];
    Random rand = new Random();
    Console.Write("Введите позицию элемента: ");
    int pos = Convert.ToInt32(Console.ReadLine());
    int search = 0;
    int result = -1;

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            array[i, j] = rand.Next(10);
            if (pos == search)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0,9}", array[i, j]);
                Console.ResetColor();
                result = array[i, j];
                search++;
                continue;
            }
            search++;
            Console.Write("{0,9}", array[i, j]);


        }
        Console.WriteLine();
    }
    if (search < pos) Console.WriteLine("Такого числа в массиве нет");
    else Console.WriteLine($"Позиция {pos} навна значению {result}");
}

void taskThree(int row, int col)
{
    Random random = new Random();
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(1, 10);
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("****************");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        Console.Write($"{sum / arr.GetLength(0)} ");
    }
}

switch (task)
{
    case 47:
        Console.WriteLine("Задача 47. Задайте двумерный массив размером m * n, заполненный случайными вещественными числами.");
        Console.Write("Введите число m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        taskOne(m, n);
        break;

    case 50:
        Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
        Console.Write("Введите число x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        taskTwo(x, y);
        break;

    case 52:
        Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
        Console.Write("Введите число row: ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число col: ");
        int col = Convert.ToInt32(Console.ReadLine());
        taskThree(row, col);
        break;
}