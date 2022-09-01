Console.WriteLine("Вас приветствует мой деревянный скрипт)");
Console.WriteLine("Введите номер задания, котоое хотите проверить: 19, 21 или 23");
int task = Convert.ToInt32(Console.ReadLine());

string taskOne(int numberOne)
{
    string result = string.Empty;
    
    string str = Convert.ToString(numberOne);

    int index = str.Length;
    bool value = true;
    if(index == 5)
    {
        for(int i = 1; i <= index; i++)
        {
            int a = str[i - 1];
            int b = str[index - i];

            if(a == b) continue;
            else value = false;
        }
        if(value == true) return result = "Число "+ numberOne +" - палиндром.";
        else return result = "Число "+ numberOne +" - не палиндром.";
    }
    else return result = "Необходимо ввести 5-значное число. Вы ввели "+ index +"-значное. Пожалуйста, повторите попытку";
}

double taskTwo(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double resultTwo = Math.Pow((Math.Pow(x2 - x1, 2) +
                                Math.Pow(y2 - y1, 2) +
                                Math.Pow(z2 - z1, 2) * 1.0), 0.5);
    return resultTwo;
}

string taskThree(int numberThree)
{
    string resultThree = string.Empty;

    double numberThreeX = Convert.ToDouble(numberThree);
    double cube = 3;
    
    for(int i = 1; i <= numberThree; i++)
    {
        resultThree += Math.Pow(i, cube);
        resultThree += " ";
    }
    return resultThree;
}

switch(task)
{
    case 19:
        Console.WriteLine("ЗАДАЧА 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
        Console.WriteLine("Введите пятизначное число");
        int numberOne = Convert.ToInt32(Console.ReadLine());

        string resultOne = taskOne(numberOne); // Отправляем параметр в функцию первого задания

        Console.WriteLine(resultOne); // Выводим результат работы функции
        break;
    case 21:
        Console.WriteLine("ЗАДАЧА 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
        Console.WriteLine("Введите три числа для точки А");
        float x1 = Convert.ToInt32(Console.ReadLine());
        float y1 = Convert.ToInt32(Console.ReadLine());
        float z1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите три числа для точки B");
        float x2 = Convert.ToInt32(Console.ReadLine());
        float y2 = Convert.ToInt32(Console.ReadLine());
        float z2 = Convert.ToInt32(Console.ReadLine());

        double resultTwo = taskTwo(x1, y1, z1, x2, y2, z2); // Отправляем параметры в функцию второго задания

        Console.WriteLine(resultTwo); // Выводим результат работы функции
        break;
    case 23:
        Console.WriteLine("ЗАДАЧА 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
        Console.WriteLine("Введите число");
        int numberThree = Convert.ToInt32(Console.ReadLine());

        string resultThree = taskThree(numberThree); // Отправляем параметр в функцию третьего задания

        Console.WriteLine(resultThree); // Выводим результат работы функции
        break;
}
