// 27. Определить количество цифр в числе

 int CountDigits(int n)
{   int count = 0;
    if(n==0) count=1;
     else                     
    while (n != 0)
    {
        n /= 10;
        count++;
    }

    return count;
}

Console.WriteLine("введите число");
int number=Convert.ToInt32(Console.ReadLine());
int num=CountDigits(number);
Console.WriteLine(num);