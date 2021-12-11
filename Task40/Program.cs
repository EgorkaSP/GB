// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
int[] arr=new int[10];
void FillArray(int[] col)
{
    for (int i = 0; i <col.Length; i++)
    {
        col[i]=new Random().Next(1,100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}

int FindMax(int[] Array)
{
    int maxPosition = 0;
    for ( int i = 0; i < Array.Length - 1; i++)
    {

        for (int j = i + 1; j < Array.Length; j++)
        {
            if (Array[j] > Array[maxPosition]) maxPosition = j;
        }


    }
    return Array[maxPosition];
}

int FindMin(int[] array)
{
    int minPosition = 0;
    
    for ( int i = 0; i < array.Length - 1; i++)
    {

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }


    }
    return array[minPosition];
}

FillArray(arr);
PrintArray(arr);
Console.WriteLine();
//int result=FindMax(arr)-FindMin(arr);
Console.WriteLine(FindMax(arr)-FindMin(arr));