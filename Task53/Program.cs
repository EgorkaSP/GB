//53.  В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
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

void Find(int[,] array,int number)
{  int row = -1;
    int column = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                row = i;
                column = j;
                Console.WriteLine("индекс строки " + row + "," + " индекс столбца " + column);
            }
        }
    }
}

Find(Matrica,1);
