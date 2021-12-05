// 28. Подсчитать сумму цифр в числе
Console.WriteLine("введите число");
int N=Convert.ToInt32(Console.ReadLine());
int sum=0;
while(N!=0)
{
    sum+=N%10;
    N/=10;
    }
Console.WriteLine( "сумма чисел " + sum);

