//Рекурсия задачи примеры
// Написать функцию, формирующую строковую последовательность целых чисел от 1 до number.
string GetSequence(int number) //функция которая возвращает строку
{
    if (number == 1) return " " + number;
    return GetSequence(number - 1) + " " + number;
}
int myNumber = 10;
Console.WriteLine("последовательность: " + GetSequence(myNumber));
