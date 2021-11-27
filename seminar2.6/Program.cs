// 13. выяснить кратно ли число заданному, если нет, то вывести остаток
int Const=3;
int some_number=new Random().Next(1,100);
Console.WriteLine(some_number);
int result= some_number%Const;
if(result==0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine(result);
}