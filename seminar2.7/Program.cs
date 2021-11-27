// 14. найти третью цифру числа или сообщить что ее нет
int number=new Random().Next(1,1000);
Console.WriteLine(number);
int result=number%10;
if(number>100)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("3-ей цифры нет");
}

