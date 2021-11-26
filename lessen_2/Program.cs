// процедурный подход к написанию кода, это когда используют функции и массивы
//Например Next WriteLine  это тоже функции
//в си шарп функция называется методом
//функция имеет идентификатор ( имя), которое придумываю я, может иметь входные аргументы, может возвращать значения
// ПРИМЕР  общего описания ФУНКЦИИ:
// ВозвращаемыйТипДанных_ИмяМетода([ТипДанных1_Имя аргумента1,...])
// {
//   тело метода
//   return ЗначениеСоответствующееВозвращаемомуТипуДанных;
// }
 int Max(int arg1, int arg2, int arg3)
{
    int result=arg1;
    if(arg2>result) result=arg2;
    if(arg3>result) result=arg3;
    return result;
}

//int a1=15;
//int b1= 27681;
//int c1=39;
//int a2=12;
//int b2= 253;
//int c2=353;
//int a3=13;
//int b3= 273;
//int c3=336;

//int max1 = Max(a1, b1, c1);  Или можно короче см ниже
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);

//int max = Max(Max(a1, b1, c1),Max(a2, b2, c2) ,Max(a3, b3, c3) );

//Console.WriteLine(max);


//       Массивы
// объявление массива
//Тип данных[]Имя={Значение1, Значение2...}
// int[] array={3,7,98,5...}
// int[] array=new int[5];
// int[] array={0,0,0,0,0};
// int[] array=new int[]{0,0,0,0,0};
// int[] array=new int[5]{0,3,2,1,0};
//              0  1  2  3  4  5  6  7  8
int[] array = {14,42,43,45,56,76,87,88,95};

int result = Max ( 
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
    );
Console.WriteLine(result);