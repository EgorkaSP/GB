// 30.Показать кубы чисел, заканчивающихся на четную цифру

double number=Convert.ToDouble(new Random().Next(1,10000));
Console.WriteLine(number);
double lastDigit=number%10;
if(lastDigit%2==0)
{
    double result= Math.Pow(number,3);
    Console.WriteLine(result);
}
else Console.WriteLine("последняя цифра нечетная");

