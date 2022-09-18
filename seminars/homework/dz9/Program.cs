Console.Clear();
Console.WriteLine("Введите номер задания, которое хотите проверить: 64, 66 или 68");
int task = Convert.ToInt32(Console.ReadLine());

void ShowNaturalNumbers(int start, int end)
{
    while (start < end)
    {
        Console.Write($"{start}, ");
        start++;
    }
    Console.Write(start);
}

int SearchSumNaturalNumber(int m, int n)
{
    int sum = 0;
    while (m <= n)
    {
        sum += m;
        m++;
    }
    return sum;
}

int CalculationAkkerman(int m, int n)
{
    if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
    if (n == 0) return m + 1;
    if (m == 0) return CalculationAkkerman(n - 1, m);
    return CalculationAkkerman(n - 1, CalculationAkkerman(n, m - 1));
}

switch (task)
{
    case 64:
        Console.WriteLine("Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
        Console.Write("Введите число M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        ShowNaturalNumbers(start: m, end: n);
        break;
    case 66:
        Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
        Console.Write("Введите число M: ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число N: ");
        int end = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(SearchSumNaturalNumber(m: start, n: end));
        break;
    case 68:
        Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
        Console.Write("Введите число M: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число N: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(CalculationAkkerman(m: a, n: b));
        break;
}
