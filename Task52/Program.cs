// 52.В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
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

void Math(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i%2==0 && j%2==0)
            {
                arr[i,j]*=arr[i,j];
                
            }
        }
    } 
}  

Console.WriteLine();
Math(Matrica);
PrintArray(Matrica);
