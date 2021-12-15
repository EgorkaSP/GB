// Написать программу, которая обменивает элементы первой строки и последней строки

// int[,] array ={{1,2,3},{4,5,6},{7,8,9},{10,11,12}};
// int[,] arrayCopy =new int[array.GetLength(0), array.GetLength(1)];
// Array.Copy(array, arrayCopy, array.Length);


// int[,] array = new int[2,2];
// array [0,0] = 1;
// array [0,1] = 1;
// array [1,0] = 2;
// array [1,1] = 2;

// int [] m = new int [2];

void FillArray(int[,] matrix, int m, int n)
{
    for (int i = 0; i <matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            matrix[i,j]=new Random().Next(m,n);
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
 
 
void Copy(int[,] array, int[] m)
{
    for (int i = 0; i < m.Length; i++)
    {
        m[i] = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = m[i];

    }
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int r = 0; r < array.GetLength(1); r++)
        {
            Console.Write(array[k, r] + " ");
        }
        Console.WriteLine();
    }
}
 
 
Console.Write("введите m: ");
int lengthM=int.Parse(Console.ReadLine());
Console.Write("введите n:");
int lengthN=int.Parse(Console.ReadLine());
int[,] matrica=new int[lengthM,lengthN];
 
FillArray(matrica, 1,10);
PrintArray(matrica);
Console.WriteLine();
int[]M=new int[lengthM];
Copy(matrica,M);







