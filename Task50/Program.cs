// 50. В двумерном массиве n×k заменить четные элементы на противоположные
void FillArray(int[,] matr, int min,int max)
{
    for (int i = 0; i <matr.GetLength(0); i++)
    {
        for (int j = 0; j <matr.GetLength(1); j++)
        {
            matr[i,j]=new Random().Next(min,max);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i <matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

Console.Write("введите n ");
int lengthN=int.Parse(Console.ReadLine());
Console.Write("введите k ");
int lengthK=int.Parse(Console.ReadLine());

int[,] Matrica=new int[lengthN,lengthK];
FillArray(Matrica,1,10);
PrintArray(Matrica);

void Mirror(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] *= -1;
        }
    }
}

Mirror(Matrica);
Console.WriteLine();
PrintArray(Matrica);