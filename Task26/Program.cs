// 26. Возведите число А в натуральную степень B используя цикл
int Pow(int A,int B)
{ int result=A;
    for (int i = 1; i < B; i++)
    {
        result*=A;
        
    }
return result;
}

Console.WriteLine("Ведите а");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите b");
int b=Convert.ToInt32(Console.ReadLine());
Console.Write("результат=");

int pow=Pow(a,b);
Console.Write(pow);