﻿// типы данных: 
//                1. целые числа:
// byte  от -128 до 127 ( занимает память 8 бит)
// short от -32 тыс до 32 тыс ( занимает 16 бит)
//int  от -2 млн до 2 млн (занимает 32 бита)
int myInt= 10;
//long еще больше чем инт ( занимает 64 бита)
//                2. с плавающей запятой
// float
// double после запятой больше цифр, следовательно более точные вычисления
double myDouble=3.14;
//                3. символьный
// char например: а,в определяется таблицами кодировок
char meChar='a'; // Только одинарные кавычки и только один символ одной переменной задается
//                4. логический
// bool (true/false)
bool myBool= true;
//                5. строки
// string массив символов
string myString="это строка"; //все что в двойных кавычках это строка
// Переменная символизирует собой выделенное место в памяти , в которое мы будем складывать какой либо тип данных
// Синтаксис объявления переменной с инициализацией-тип данных->имя переменной=значение (значение должно совпадать по типу данных с переменной)
//           Условный оператор
// if(условие)
// {
//     тело из наборов операторов     
// }
// в условии используются следующие математические операторы: > < >=(большеравно) <=(меньше равно) ==(равно) != (не равно)
// и логические операторы : && (и) || (или) !(отрицание)
// Например: 
if(5>4) // условие выполняется тогда  и только тогда, когда будет истина в круглых скобках
{
    Console.WriteLine("5 > 4");
}
// также можно в условие добавлять переменные, но их надо заранее объявить, например
int first= 3;
int second= 10;
if(first>second)
{
    Console.WriteLine("3 > 10");
}
// Или Конкатенация строк (сцепление) — это операция объединения строк. 
//Для этой операции в Java используется знак +.
// К строке можно присоединять не только другую строку, но и значение любого другого типа, 
// которое будет преобразовано к строке автоматически.
// Console.WriteLine(first +"<"+ second); 
else // выполняется альтернативная ветка только когда условие в иф ложно
{
    Console.WriteLine("kjglk");
}
// Также можно писать больше ветвлений, например:
// else if(first>second)
// {
//    Console.WriteLine(first +">"+ second);
// }
// Чтобы считать в консоль то что ввводит пользователь в терминале, используй ридлайн,
// значение, которое считывается этой функцией надо положить в переменную, 
//она всегда считывает строчку, значит надо использовать тип данных строка, то есть
// string a = Console.ReadLine(); // лучше добавлять приглашение ко вводу строки, чтобы понимать что от нас ждет комп
// Console.WriteLine(a);
// так как ридлайн считывает только строки, чтобы преобразовать в число используй парс, то есть:
// int b = int.Parse(Console.ReadLine()); 
// Console.WriteLine(b);
// Чтобы найти корень используй функцию скуэртэ, она возвращает числа типа дабл, то есть: 
double c=Math.Sqrt(9);
Console.WriteLine(c);
// чтобы найти кубический корень, надо возвести в степень 1/3  это:
Console.WriteLine(Math.Pow(27, 1.0/3.0));
// y=(f)x
//например y=x-1, x>=0;
// y=|x|,x<=0;
int x= -1;
if (x>=0)
{
    Console.WriteLine(x-1);
    
}
else if (x<0)
{
    Console.WriteLine(Math.Abs(x)); // взятие модуля это функция абс из класса Math
}
// выяснить является ли число четным
int lastTaskValue=5;           // перевод значение последней задачи
if (lastTaskValue%2==0)
{
    Console.WriteLine("оно четное");
    
}
else 
{
    Console.WriteLine("оно нечетное");

}