// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int[] arr=new int[12];
void FillArray(int[] array)
{
    for (int i = 0; i <array.Length; i++)
    {
        array[i]=new Random().Next(-9,10);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i <array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

FillArray(arr);
PrintArray(arr);
void ArraySum(int[] array)
{
    int sum1 = 0;
    int sum2 = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] > 0) sum1 += array[i];
              
        else sum2 += array[i];
        
    }
Console.WriteLine("сумма положительных " + sum1);
Console.WriteLine("сумма отрицательных " + sum2);
}
ArraySum(arr);