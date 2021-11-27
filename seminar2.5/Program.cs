// 12. удалить вторую цифру из 3 значного числа
int three_digit_number=new Random().Next(100,1000);
Console.WriteLine(three_digit_number);
int first_digit=three_digit_number/100;
int last_digit= three_digit_number%10;
Console.WriteLine(first_digit+ "" +last_digit);
//String First_digit = Convert.ToString(first_digit);
//String Last_digit = Convert.ToString(last_digit);
//Console.Write(First_digit+" "+Last_digit);
