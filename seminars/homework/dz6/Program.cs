internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Введите номер задания, которое хотите проверить: 41 или 43");
        int task = Convert.ToInt32(Console.ReadLine());

        void CountingZero(int couting)
        {
            int count = 0;
            for (int i = 1; i < couting + 1; i++)
            {
                Console.WriteLine($"Введите {i}-е число");
                double number = Convert.ToDouble(Console.ReadLine());
                if (number > 0) count++;
            }
            Console.WriteLine($"Введено {count} чисел больше 0");
        }

        void SearchIntersection(double b1, double k1, double b2, double k2)
        {
            double x = (-b2 + b1) / (-k1 + k2);
            double y = k2 * x + b2;

            Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
        }

        switch (task)
        {
            case 41:
                Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
                Console.WriteLine("Сколько чисел Вы хотите ввести?");
                int m = Convert.ToInt32(Console.ReadLine());
                CountingZero(m);
                break;

            case 43:
                Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
                Console.WriteLine("Введите значение для b1");
                double b1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение для k1");
                double k1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение для b2");
                double b2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение для k2");
                double k2 = Convert.ToInt32(Console.ReadLine());
                SearchIntersection(b1, k1, b2, k2);
                break;
        }
    }
}