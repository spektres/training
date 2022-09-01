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

string taskTwo(int numberTwo)
{
    string result = string.Empty;
    
    for(int i = 0; i < numberTwo; i++)
    {
        result = "q";
    }
}

switch(task)
{
    case 19:
        Console.WriteLine("ЗАДАЧА 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
        Console.WriteLine("Введите пятизначное число");
        int numberOne = Convert.ToInt32(Console.ReadLine());
        string resultOne = taskOne(numberOne);
        Console.WriteLine(resultOne);
        break;
    case 21:
        Console.WriteLine("ЗАДАЧА 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

        break;
    case 23:
        Console.WriteLine("ЗАДАЧА 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
        Console.WriteLine("Введите число");
        int numberTwo = Convert.ToInt32(Console.ReadLine());
        string resultTwo = taskTwo(numberTwo);
        Console.WriteLine(resultTwo);
        break;
}
