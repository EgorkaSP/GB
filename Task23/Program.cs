// Показать таблицу квадратов чисел от 1 до N
Console.WriteLine("введите число N");
int N=int.Parse(Console.ReadLine());
for (int i = 2; i <= N; i++)
{
    Console.WriteLine($"{i}*{i}={i*i}");
    Console.WriteLine();
}


