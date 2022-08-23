/* void - метод, который ничего не возвращает. 
Т.е. метод не должен использовать оператор return*/

void FillArray(int[] collection)
{
    int lenght = collection.Length; // Получение длины массива
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10); // Даем случайное число из диапозона 1-10
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10]; // Создать новый массив, в котором 10 элементов. По умолчанию заполнен нулями.

FillArray(array); // Метод, заполняющий массив
PrintArray(array); // Метод, распечатывающий массив