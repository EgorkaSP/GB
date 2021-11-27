// 10. показать вторую цифру 3 значного числа
Console.WriteLine("введите 3 значное число");
int three_digit_number=int.Parse(Console.ReadLine());
int last_digit=three_digit_number % 100;
int second_digit=last_digit / 10;
Console.WriteLine(second_digit);

