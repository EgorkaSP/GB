// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] Arr= new int[40];
void FillArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i]=new Random().Next(1,100);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i <array.Length; i++)
    {
       
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FillArray(Arr);
PrintArray(Arr);


for (int i = 0; i < Arr.Length/2; i++ )
{
    
    Console.WriteLine($"{Arr[i]}*{Arr[Arr.Length-i-1]} {Arr[i]*Arr[Arr.Length-i-1]} ");


}