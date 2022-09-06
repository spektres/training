Console.Clear();
Console.WriteLine("Введите номер задания, которое хотите проверить: 34, 36 или 38.");
int task = Convert.ToInt32(Console.ReadLine());

int taskOne()
{
    Console.WriteLine("Введите колличество элементов массива (элементы будут с рандомными значениями)");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    int count = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(100, 999);
        if(array[i] % 2 == 0) count += 1;
    }
    return count;
}

int taskTwo()
{
    Console.WriteLine("Введите колличество элементов массива (элементы будут с рандомными значениями)");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(-99, 99);
        if(array[i] % 2 != 0) sum += array[i];
    }
    return sum;
}

double taskThree()
{
    Console.WriteLine("Укажите колличество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    double [] array = new double[size];
    double min = 100; double max = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"Введите {i + 1}-е число (от 0 до 100)");
        array[i] = Convert.ToDouble(Console.ReadLine());
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];
    }
    double result = max - min;
    return result;
}

switch(task)
{
    case 34: 
    Console.WriteLine("ЗАДАЧА 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
    Console.WriteLine($"Колличество четных чисел в массиве равно {taskOne()}."); break;
    case 36: 
    Console.WriteLine("ЗАДАЧА 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
    Console.WriteLine($"Сумма нечетных элементов массива равна {taskTwo()}"); break;
    case 38: 
    Console.WriteLine("ЗАДАЧА 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {taskThree()}"); break;
}

