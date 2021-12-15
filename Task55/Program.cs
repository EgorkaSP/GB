// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
void FillArray(int[,] matrix, int m, int n)
{
    for (int i = 0; i <matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            matrix[i,j]=new Random().Next(m,n);
        }
    }
}
 
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.Write("введите m: ");
int lengthM=int.Parse(Console.ReadLine());
Console.Write("введите n:");
int lengthN=int.Parse(Console.ReadLine());
int[,] matrica=new int[lengthM,lengthN];
 
FillArray(matrica, 1,10);
PrintArray(matrica);
Console.WriteLine();

void ArithmeticMean(int[,] Arr, int[] summ)
{
    for (int i = 0; i <Arr.GetLength(0); i++)
    {
        for (int j = 0; j <Arr.GetLength(1); j++)
        {
            summ[i]+=Arr[i,j];
        }
    }
    for (int i = 0; i <summ.Length; i++)
    {
        Console.Write($"{summ[i]/Arr.GetLength(1)} ");
    }
   }

int[] Sum=new int[lengthN];
ArithmeticMean(matrica,Sum);