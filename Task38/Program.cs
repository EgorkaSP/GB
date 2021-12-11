// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] Arr=new int[23];
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(1,10);
    }
}


FillArray(Arr);

Console.WriteLine();
int IndexOf(int[] collection)
{
    int sum = 0;
    for (int i = 0; i < collection.Length; i++)
    {

        if (i % 2 == 1)
            Console.WriteLine($"{"элемент"} {collection[i]} {"индекс="}{i}");

        sum += collection[i];
    }
    return sum;
}

int result=IndexOf(Arr);
Console.WriteLine("сумма = " + result);