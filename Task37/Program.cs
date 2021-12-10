// 37.В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] arr=new int[123];
void FillArray(int[] collection)
{
    for (int i = 0; i <collection.Length; i++)
    {
        collection[i]=i+1;
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


 
int Interval(int[] col)
{  int count=0;
    for (int i = 0; i <col.Length; i++)
    
        if(col[i] >=10 && col[i] < 99) count++;
        
    return count;
} 
int result=Interval(arr);
Console.WriteLine(result);