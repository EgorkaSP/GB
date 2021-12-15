//49. Показать двумерный массив размером m×n заполненный вещественными числами

void FillArray(double[,] matr, int min, int max)
{
    for (int i = 0; i <matr.GetLength(0); i++)
    {
        for (int j = 0; j <matr.GetLength(1); j++)
        {
            matr[i,j]=Math.Round(new Random().NextDouble() + new Random().Next(min,max),2);
        }
    }
}

void PrintArray(double[,] Matrica)
{
    for (int i = 0; i <Matrica.GetLength(0); i++)
    {
        for (int j = 0; j <Matrica.GetLength(1); j++)
        {
            Console.Write($"{Matrica[i,j]} " );
        }
        Console.WriteLine();
    }
}

Console.Write("введите M колличество строк: ");
int lengthM=int.Parse(Console.ReadLine());
Console.Write("введите N  колличество столбцов: ");
int lengthN=int.Parse(Console.ReadLine());
double[,] Matrica=new double[lengthM,lengthN];
FillArray(Matrica, 1,10);
PrintArray(Matrica);