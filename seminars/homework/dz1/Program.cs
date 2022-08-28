Console.WriteLine("Введите номер задания, которое хотите открыть для проверки (2, 4, 5, 6, 7 или 8)");
int task = Convert.ToInt32(Console.ReadLine());

if (task == 2)
{
    Console.WriteLine("ЗАДАЧА 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
    Console.WriteLine("Введите первое число");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int b = Convert.ToInt32(Console.ReadLine());
    
    int min = 0; int max = 0; 

    if (a > b) {max = a; min = b;}
    else {max = b; min = a;}

    Console.WriteLine("Минимальное число = " + min);
    Console.WriteLine("Максимальное число = " + max);
}

if(task == 4)
{
    Console.WriteLine("ЗАДАЧА 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");

    Console.WriteLine("Введите три числа");
    int max = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int c = Convert.ToInt32(Console.ReadLine());

    if(max < b) max = b;
    if(max < c) max = c;

    Console.WriteLine("Максимальное число: " + max);
}

if(task == 5)
{
    Console.WriteLine("ЗАДАЧА 5*: Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.");
    Console.WriteLine("Введите число");
    int x = Convert.ToInt32(Console.ReadLine());
    int y = x * -1;
    int i = y;

    while(y <= i && i <= x)
    {
        Console.Write(i + ", ");
        i++;
    }
}

if(task == 6)
{
    Console.WriteLine("ЗАДАЧА 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
    Console.WriteLine("Введите число");
    int x = Convert.ToInt32(Console.ReadLine());
    if(x % 2 == 0)
    {
        Console.WriteLine("ДА, число " + x + " делится на 2 без остатка:)");
    }
    else Console.WriteLine("НЕТ, число " + x + " не делится на 2 без остатка");
}

if(task == 7)
{
    Console.WriteLine("ЗАДАЧА 7*: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.");
    Console.WriteLine("Введите 3-х значное число");
    int x = Convert.ToInt32(Console.ReadLine());

    if( 100 <= x && x < 1000)
    {
        int result = x % 10;
        Console.WriteLine("Последней цифрой числа " + x + " является - " + result);
    }
    else Console.WriteLine("Число не являетя 3-х значным");
}

if(task == 8)
{
    Console.WriteLine("ЗАДАЧА 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
    Console.WriteLine("Введите число");
    int n = Convert.ToInt32(Console.ReadLine());
    int i = 2;
    while (i <= n)
    {
        Console.Write(i + ", ");
        i += 2;
    }
}
