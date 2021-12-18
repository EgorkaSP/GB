// 57. Написать программу, упорядочивания по убыванию элементов каждой строки двумерного массива.
  
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
 
Console.Write("введите m: ");
int lengthM=int.Parse(Console.ReadLine());
Console.Write("введите n:");
int lengthN=int.Parse(Console.ReadLine());
int[,] matrica1=new int[lengthM,lengthN];
//int[] matrica2=new int[lengthM*lengthN];
 
FillArray(matrica1, 1,10);
PrintArray(matrica1);
Console.WriteLine();

// void Conversion(int[,] Array1, int[] Array2)
// {
//     int z = 0;
//     for (int i = 0; i < Array1.GetLength(0); i++)
//         for (int j = 0; j < Array1.GetLength(1); j++)
//         {
//             Array2[z] = Array1[i, j];
//             Console.Write(Array2[z] + " ");
//             z++;

//         }
//     for (int i = 0; i < Array2.Length-1; i++)
//     {
//         int maxPosition=i;
//         for (int j = i+1; j < Array2.Length; j++)
//         {
//             if(Array2[j]>Array2[maxPosition]) maxPosition=j;
//         }

//         int temp=Array2[i];
//         Array2[i]=Array2[maxPosition];
//         Array2[maxPosition]=temp;

//     }



// }

// Conversion(matrica1,matrica2);

void SelectionSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0) ; i++)
    {
        for (int j = 0 ; j < array.GetLength(1)-1; j++)
        {
            for (int k =j+1; k < array.GetLength(1); k++)
            {
                int maxPosition = j;
                if (array[i, k] > array[i,maxPosition]) maxPosition = k;
                int temp = array[i, j];
                array[i, j] = array[i,maxPosition];
                array[i,maxPosition] = temp;

            }
        }

    }
}

SelectionSort(matrica1);
PrintArray(matrica1);