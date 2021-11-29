// 17. По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("введите 2 числа");
int Num1=int.Parse(Console.ReadLine());
int Num2=int.Parse(Console.ReadLine());
if(Num1*Num1==Num2 || Num2*Num2==Num1 )
{
    Console.WriteLine(" одно квадрат другого");
     }
  else
  {
      Console.WriteLine("  не квадрат ");
  }   
