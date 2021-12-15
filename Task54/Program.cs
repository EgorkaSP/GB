// 54. В матрице чисел найти сумму элементов главной диагонали
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

int MainDiagonal(int[,] cub)
{ int sum=0;
    for (int i = 0; i <cub.GetLength(0); i++)
    {
        for (int j = 0; j <cub.GetLength(1); j++)
        {
            if(i==j)
            {
                sum+= cub[i,j];
            }
        }
    }
    return sum;
}
int Sum=MainDiagonal(Matrica);
Console.WriteLine(Sum);