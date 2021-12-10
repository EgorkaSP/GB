// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] Array=new int [10];
void FillArray(int[] arr)
{
    for (int i = 0; i <arr.Length; i++)
    {
        arr[i]=new Random().Next(100,1000);
    }
}

void PrintArray(int[] col)
{
    for (int i = 0; i <col.Length; i++)
    {
        Console.WriteLine(col[i]);
    }
}

FillArray(Array);
PrintArray(Array);
Console.WriteLine();

void Parity(int[] collection)
{
    int result1 = 0;
    int result2 = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] % 2 == 0)
        {
            result1 = collection[i];
            Console.Write("четные: " + result1 + ",");
        }
        else if (collection[i] % 2 != 0)
        {
            {
                result2 = collection[i];
                Console.WriteLine("нечетные: " + result2 + ",");
            }


        }
    }
}

    Parity(Array);