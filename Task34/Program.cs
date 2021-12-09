// 34. Написать программу замену элементов массива на противоположные
int[] arr=new int[10];
void FillArray(int[] array)
{
    for (int i = 0; i <array.Length; i++)
    {
        array[i]=new Random().Next(-111,112);
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
Console.WriteLine();

void Mirror(int[] array)
{ 
   for (int i = 0; i < array.Length; i++)
   {
       array[i]*= -1;
   }
      
    
}

Mirror(arr);
PrintArray(arr);