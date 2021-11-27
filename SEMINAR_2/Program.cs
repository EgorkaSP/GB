void PrintArray(int[] natural)
{
    int size=natural.Length;
    int index=0;
        while(index<size)
        {
            Console.WriteLine(natural[index]);
            index++;
        }
}
int[] array={-5,-4,-3,-2,-1,0,1,2,3,4,5};
PrintArray(array);
Console.WriteLine();

// или так
Console.WriteLine("Введите число N");
int N= int.Parse(Console.ReadLine());
int count=-N;
while(count<N+1)  // или count<=N
{
    Console.WriteLine(count);
    count++;
}