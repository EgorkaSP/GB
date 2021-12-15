// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n
Console.WriteLine("введите m: ");
int lengthM=int.Parse(Console.ReadLine());
Console.WriteLine("введите n ");
int lengthN=int.Parse(Console.ReadLine());

int[,] A=new int[lengthM,lengthN];
for (int i = 0; i <A.GetLength(0); i++)
{
    for (int j = 0; j <A.GetLength(1); j++)
    {
        Console.Write($"{i} + {j} ={A[i,j]=i+j}  ");
    }
    Console.WriteLine();
}