//31. Задать массив из 8 элементов и вывести их на экран
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]=new Random().Next(1,100000);
        
        
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

int[] Array=new int[8];
FillArray(Array);
PrintArray(Array);
