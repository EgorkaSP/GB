// 48. Показать двумерный массив размером m×n заполненный целыми числами
int[,] Matrix=new int[3,5];

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

void FillArray(int[,] matrix)
{
    for (int i = 0; i <matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            matrix[i,j]=new Random().Next(1,100);
        }
    }
}

FillArray(Matrix);
PrintArray(Matrix);