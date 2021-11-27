// 9. показать последнюю цифру 3значного числа
Console.WriteLine("введите 3 значное число");
int three_digit_number=int.Parse(Console.ReadLine());
int last_digit= three_digit_number%10;
Console.WriteLine(last_digit);
