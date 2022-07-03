//нахождение максимума из 9 чисел, массив

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = {22, 54, 65, 41, 765, 23, 7, 43, 4822};
array[0] = 5679;
Console.WriteLine(array[5]);

int max =Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])
    );

Console.WriteLine(max);
