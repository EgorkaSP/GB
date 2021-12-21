// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы
// или сообщить, что это невозможно (в случае, если матрица не квадратная).

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
int lengthM = int.Parse(Console.ReadLine());
Console.Write("введите n:");
int lengthN = int.Parse(Console.ReadLine());
int[,] matrica1 = new int[lengthM, lengthN];
FillArray(matrica1, 1, 10);
// PrintArray(matrica1);
// Console.WriteLine();
// if(lengthM==lengthN )
// {
//     Transfer();

// }
// else Console.WriteLine("матрица не квадратная");

int[,] Transfer(int[,] arr)
{ int column=arr.GetLength(0);
int row=arr.GetLength(1);
    int[,] result = new int[row,column];
    for (int i = 0; i <row ; i++)
    {
        for (int j = 0; j < column; j++)
        {

            result[j, i] = arr[i, j];



        }
    }
    return result;
} 
DateTime saveTime = DateTime.Now;

int[,] res = Transfer(matrica1);
Console.WriteLine($"{DateTime.Now - saveTime}");

// for (int i = 0; i < res.GetLength(0); i++)
// {
//     for (int j = 0; j < res.GetLength(1); j++)
//     {
//         Console.Write($"{res[i, j]} ");
//     }
//     Console.WriteLine();
// }
