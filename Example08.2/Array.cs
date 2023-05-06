// Нахождение максимального числа с помощью функции (метода) и массива.
int Max(int Arg1, int Arg2, int Arg3)
{
    int result = Arg1;
    if (Arg2 > result) result = Arg2;
    if (Arg3 > result) result = Arg3;
    return result;
}

int[] array = {12, 22, 31, 14, 56, 68, 177, 28, 39};

int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));

Console.WriteLine(max);
