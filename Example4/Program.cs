//найти элемент массива, равный find. Если array [index] = find, алгоритм завершил работу успешно.

int[] array = { 33, 12, 65, 8, 98, 3, 432, 8 };

int n = array.Length;
int find = 8;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}