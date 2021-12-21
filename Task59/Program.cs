// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.
void FillArray(int[,] matrix, int m, int n)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(m, n);
        }

    }
}

void PrintArray(int[,] matr)
{ int sum=0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {  sum=0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum+=matr[i,j];
                        Console.Write($"{matr[i, j]} ");
        }
              Console.WriteLine("сумма строки " +sum);
    }
}
Console.Write("введите m: ");
int lengthM = int.Parse(Console.ReadLine());
Console.Write("введите n:");
int lengthN = int.Parse(Console.ReadLine());
int[,] matrica = new int[lengthM, lengthN];

FillArray(matrica, 1, 10);
PrintArray(matrica);
Console.WriteLine();



if (lengthM != lengthN)
{
   Console.WriteLine(MinSumm(matrica));
}
else Console.WriteLine("матрица не прямоугольная");


int MinSumm(int[,] array)
{
    int temp = -1;
    int s = 0;
    int sMin = int.MaxValue;  // f12
    for (int i = 0; i < array.GetLength(0); i++)
    {
        s = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            s += array[i, j];

        }
        if (s <= sMin)
        {
            sMin = s;
            temp = i;

        }

    }

    return temp;
}

//работает, убери тест
