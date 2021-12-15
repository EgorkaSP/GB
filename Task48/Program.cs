// 48. Показать двумерный массив размером m×n заполненный целыми числами

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

Console.Write("введите m: ");
int lengthM=int.Parse(Console.ReadLine());
Console.Write("введите n:");
int lengthN=int.Parse(Console.ReadLine());
int[,] matrica=new int[lengthM,lengthN];

FillArray(matrica, 1,10);
PrintArray(matrica);