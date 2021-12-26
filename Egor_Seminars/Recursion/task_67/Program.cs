// 67.Показать натуральные числа от N до 1, N задано

string GetSequens(int number)

{

    if (number == 1) return number.ToString();
    return number +  " " + GetSequens(number - 1);

}


int myNum = 15;
Console.WriteLine("последовательность: " + GetSequens(myNum));