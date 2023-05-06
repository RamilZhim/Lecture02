// Имеется одномерный массив array из n элементов. 
// Требуется найти элемент массива, равный find.

int[] array = {12, 24, 13, 4, 65, 6, 13, 81};

int n = array.Length;
int find = 13;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}