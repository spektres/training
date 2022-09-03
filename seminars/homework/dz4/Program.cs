Console.WriteLine("Введите номер задания, которое хотите проверить: 25, 27 или 29");
int task = Convert.ToInt32(Console.ReadLine());

void taskOne()
{
    Console.WriteLine("ЗАДАЧА 25: Напишите (цикл?программу?), который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
    Console.WriteLine("Введите значение для числа А");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение для числа В");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($" Числом {a} в степени {b} является {Math.Pow(a, b)}");
}

void taskTwo()
{
    Console.WriteLine("ЗАДАЧА 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
    Console.WriteLine("Введите любое число");
    int number = int.Parse(Console.ReadLine());
    int sum = 0;
    while(number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    Console.WriteLine($"Сумма цифр равна {sum}");
}

void taskThree()
{
    Console.WriteLine("ЗАДАЧА 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
    Console.WriteLine("Введите 8 чисел");
    int[] array = new int[8];
    for(int i = 0; i < array.Length ;i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Массив: " + String.Join(" ", array));
}

switch(task)
{
    case 25: taskOne(); break;
    case 27: taskTwo(); break;
    case 29: taskThree(); break;
}