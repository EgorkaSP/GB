// 21. Программа переворачивает пятизначное число.
void FillArray(int[] collection)
{
    int size=collection.Length;
   
    for( int index=0; index < size; index++)
        {
            collection[index]=new Random().Next(0,10);
        };
}

void PrintArray(int[] col)
{
    int count=col.Length;
    for (int Index = 0; Index < count; Index++)
    {
        Console.Write(col[Index]);

    }
}

int[] fiveDigitNumber=new int[5];

 FillArray(fiveDigitNumber);
 Console.WriteLine("Дано пятизначное число:");
 PrintArray(fiveDigitNumber);
 

 void ExpandArray(int[] array)
{   int Size=array.Length;
        for(int currentIndex=0; currentIndex<Size/2; currentIndex++)
            {
                int temp=array[currentIndex];
                array[currentIndex]=array[Size-currentIndex-1];
                array[Size-currentIndex-1]=temp;
             }
} 

ExpandArray(fiveDigitNumber);
Console.WriteLine();
Console.WriteLine("его палиндром:");
PrintArray(fiveDigitNumber);