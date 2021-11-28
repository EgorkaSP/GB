// 15. Дано число проверить кратно ли оно 7 и 23
int NOK=23*7;
int number=new Random().Next(161,100000);
Console.WriteLine(number);
if(number/NOK==0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("не кратно");
}
