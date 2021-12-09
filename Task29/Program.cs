// 29 найти произведение чисел от 1 до N
Console.WriteLine("введите N");
int N=Convert.ToInt32(Console.ReadLine());
int product=1;
for (int i = 2; i <= N; i++)
{
     product*=i;
            
}
Console.WriteLine("произведение равно " + product);