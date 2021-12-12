//49. Показать двумерный массив размером m×n заполненный вещественными числами
double[,] matrix=new double[5,7];
void FillArray(double[,] matr)
{
    for (int i = 0; i <matr.GetLength(0); i++)
    {
        for (int j = 0; j <matr.GetLength(1); j++)
        {
            matr[i,j]=new Random().NextDouble;
        }
    }
}

void PrintArray(double[,] Matrica)
{
    for (int i = 0; i <Matrica.GetLength(0); i++)
    {
        for (int j = 0; j <Matrica.GetLength(1); j++)
        {
            Console.WriteLine($"{Matrica[i,j]}" );
        }
        Console.WriteLine();
    }
}