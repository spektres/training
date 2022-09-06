Console.WriteLine("Введите номер задания, которое хотите проверить: 34, 36 или 38.");
int task = Convert.ToInt32(Console.ReadLine());

int taskOne()
{
    Console.WriteLine("ЗАДАЧА 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
    int[] array = new int[10];
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
    Console.WriteLine("ЗАДАЧА 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
    int[] array = new int[10];
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(-99, 99);
        if(array[i] % 2 != 0) sum += array[i];
    }
    return sum;
}

switch(task)
{
    case 34: Console.WriteLine($"Колличество четных чисел в массиве равно {taskOne()} из 10."); break;
    case 36: Console.WriteLine($"Сумма нечетных элементов массива равна {taskTwo()}"); break;
}

