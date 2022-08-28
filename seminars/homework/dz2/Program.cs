Console.WriteLine("Введите номер задания, которое хотите проверить: 10, 13 или 15");
int task = Convert.ToInt32(Console.ReadLine());

switch (task) {
    case 10:
        Console.WriteLine("ЗАДАЧА 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
        Console.WriteLine("Введите число");
        int NumberInt = Convert.ToInt32(Console.ReadLine());
        string NumberString = Convert.ToString(NumberInt);
        Console.WriteLine("Второй цифрой числа " + NumberInt + " является " + NumberString[1]);
        break;

    case 13:
        Console.WriteLine("ЗАДАЧА 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
        Console.WriteLine("Введите число");
        int NumberInt2 = Convert.ToInt32(Console.ReadLine());
        if(99 < NumberInt2){
                    string NumberString2 = Convert.ToString(NumberInt2);
                    Console.WriteLine("Третьей цифрой числа " + NumberInt2 + " является " + NumberString2[2]);
        }
        else Console.WriteLine("Третьей цифры нет");
        break;

    case 15:
        Console.WriteLine("ЗАДАЧА 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
        int day = Convert.ToInt32(Console.ReadLine());
        if(0 < day && day < 8){
            switch(day){
                case 6: Console.WriteLine(day + " - Это суббота, выходной."); break;
                case 7: Console.WriteLine(day + " - Это воскресенье, выходной."); break;
                default:
                    Console.WriteLine("Будни. На работу...");
                    break;
            }
        }
        else Console.WriteLine("Такого дня нет");
        break;
}