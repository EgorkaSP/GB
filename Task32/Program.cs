// 32.Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int[] arr=new int[8];
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(0,2);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

FillArray(arr);
PrintArray(arr);