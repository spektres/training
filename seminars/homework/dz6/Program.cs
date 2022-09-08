Console.Clear();
Console.WriteLine("Введите номер задания, которое хотите проверить: 41 или 43");
int task = Convert.ToInt32(Console.ReadLine());

void countingZero(int couting)
{
    int count = 0;
    for(int i = 1; i < couting + 1; i++)
    {
        Console.WriteLine($"Введите {i}-е число");
        double number = Convert.ToDouble(Console.ReadLine());
        if(number > 0) count++;
    }
    Console.WriteLine($"Введено {count} чисел больше 0");
}

void searchIntersection(int b1, int k1, int b2, int k2)
{
    
}

switch(task)
{
    case 41: 
    Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
    Console.WriteLine("Сколько чисел Вы хотите ввести?");
    int m = Convert.ToInt32(Console.ReadLine());
    countingZero(m);
    break;

    case 43:
    Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
    Console.WriteLine("Введите значение для b1");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение для k1");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение для b2");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение для k2");
    int k2 = Convert.ToInt32(Console.ReadLine());
    searchIntersection(b1, k1, b2, k2);
    break;
}
