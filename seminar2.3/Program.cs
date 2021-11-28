// 10. показать вторую цифру 3 значного числа
Console.WriteLine("введите 3 значное число");

int threeDigitNumber=int.Parse(Console.ReadLine());

int firstNumber=threeDigitNumber % 100;

int secondDigit=firstNumber / 10;

Console.WriteLine(secondDigit);

