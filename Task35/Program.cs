// 35. Определить, присутствует ли в заданном массиве, некоторое число

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

int FindNumber(int[] col)
{   int index=-1;
    Console.WriteLine("введите искомое число");
    int find=Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i <col.Length; i++)
    {
      if(col[i]==find)
      {
          index=i;
          break;
      } 
             
      
    }

   return index;
}
int findIndex=FindNumber(arr);
Console.WriteLine(findIndex);