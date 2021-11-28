// 9. показать последнюю цифру 3значного числа
Console.WriteLine("введите 3 значное число");

int threeDigitNumber=int.Parse(Console.ReadLine());

int lastDigit= threeDigitNumber % 10;

Console.WriteLine(lastDigit);
