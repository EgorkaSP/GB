// 30.Показать кубы чисел, заканчивающихся на четную цифру

int number=Convert.ToInt32(new Random().Next(1,10000));
Console.WriteLine(number);
int lastDigit=number%10;
if(lastDigit%2==0)
{
    Int64 result= (Int64)Math.Pow(number,3);
    Console.WriteLine(result);
}
else Console.WriteLine("последняя цифра нечетная");

