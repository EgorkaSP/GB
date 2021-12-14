// 41.Выяснить являются ли три числа сторонами треугольника

int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int c= Convert.ToInt32(Console.ReadLine());

if( ((a+b)>c) && ((c+a)>b) && ((b+c)>a) ) Console.WriteLine("это треугольник");
else
{
    Console.WriteLine("это не треугольник");
}