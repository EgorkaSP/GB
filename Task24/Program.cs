// 24. Найти кубы чисел от 1 до N
Console.WriteLine("введите число N");
double N=int.Parse(Console.ReadLine());
for (double i = 2; i <= N; i++)
{
    Console.Write(i+ " в кубе ");
    double cub=Math.Pow(i, 3);
    Console.WriteLine(cub);
}


