// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool x= false;
bool y= true;
if(!(x||y) == !x && !y)
{
    Console.WriteLine("утверждение истинно");
}
else
{
    Console.WriteLine("утверждение ложно");
}