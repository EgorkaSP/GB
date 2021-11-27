// 11. Дано число из отрезка 10, 99, показать наибольшую цифру числа
int find = new Random().Next(10,100);
Console.WriteLine(find);
int first_digit=find/10;
int second_digit=find%10;
if(first_digit>second_digit)
{
    Console.WriteLine(first_digit);
}
if(second_digit>first_digit)
{
    Console.WriteLine(second_digit);
}
else if(second_digit==first_digit)
{
    Console.WriteLine("они равны");
}
