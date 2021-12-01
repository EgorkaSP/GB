// 20. Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("введите номер четверти");
int quarterNumber=int.Parse(Console.ReadLine());
if(quarterNumber==1)
{
    Console.WriteLine("x>0,y>0");
}
if(quarterNumber==2)
{
    Console.WriteLine("x<0,y>0");
}
if(quarterNumber==3)
{
    Console.WriteLine("x<0,y<0");
}
if(quarterNumber==4)
{
    Console.WriteLine("x>0,y<0");
}
if(quarterNumber>4)
{
    Console.WriteLine("есть только 4 четверти");
}