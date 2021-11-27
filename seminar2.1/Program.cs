// 8. показать четные числа от 1 до N
Console.WriteLine("введите число N");
int N=int.Parse(Console.ReadLine());
int count=1;
while(count <= N)
{
    if(count % 2 == 0)
    {
        Console.WriteLine(count);
            }
    
count++;
}
