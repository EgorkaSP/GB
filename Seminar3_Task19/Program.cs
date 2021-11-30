// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
int x=new Random().Next(-100,100);
Console.WriteLine(x);
int y=new Random().Next(-100,100);
Console.WriteLine(y);
if(x!=0 && y!=0)
{
    if(x>0 && y>0 )
    {
        Console.WriteLine("это 1 четверть");
    }
    if(x<0 && y>0)
    {
        Console.WriteLine("это 2 четверть");
    }
    if(x<0 && y<0)
    {
        Console.WriteLine("это 3 четверть");
    }
    if(x>0 && y<0)
    {
        Console.WriteLine("это 4 четверть");
    }
}
else
{
    Console.WriteLine("где то был 0");
}
