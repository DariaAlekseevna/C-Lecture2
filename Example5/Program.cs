//метод заполнения массива случайными числами и печати на экран

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int [10]; //определили массив из 10 эл-тов

FillArray(array); //вызвали функцию заполнения массива
PrintArray(array); //вызвали функцию печати массива
