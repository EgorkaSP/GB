// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
Console.WriteLine("введите x");
bool x= bool.Parse(Console.ReadLine());
Console.WriteLine("введите y");
bool y= bool.Parse(Console.ReadLine());
if((!(x||y)) == (!x && !y))
{
    Console.WriteLine("утверждение истинно");
}
else
{
    Console.WriteLine("утверждение ложно");
}