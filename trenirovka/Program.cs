// войд методы ничего не возвращают
// но могут как ничего не принимать в виде аргументов, и просто выводить например одинаковый текст через консоль врайтлайн, чтобы их выхвать не надо вводить переменную
// или могут примать аргументы и ничего не возвращать
//void Metod2(string msg)
//{
   // Console.WriteLine(msg);
//}
//Metod2("этот текст");
// может принимать несколько аргументов тогда можно сделать их именнованными чтобы не цепляться за порядок переменных
//void Metod21( string msg, int count)
//{
        //for (int i = 0; i < count; i++)
            //{
              // Console.WriteLine(msg); 
            //}
//}
//Metod21(count:5, msg:"этот текст");

//метод, который что то принимает, но ничего не возвращает,
// значит ему надо указать обязательно тип данных, аргументов в скобках не будет
// но обязательно будет ретерн в теле метода
// чтобы вызвать этот метод надо придумать новую переменную, в которую будет положен этот метод
// чтобы вывести результат, надо вызвать консоль врайтлайн и туда положить придуманную переменную

// int Metod3()
// {
//     return DateTime.Now.Year; 
// }

// int year=Metod3();
// Console.WriteLine(year);

//вид4 Методы, которые и принимают и возвращают, самые частые 

// string Metod4(int count, string text)
// { 
//     string result=String.Empty;
//         for(int i=0; i < count; i++ )
//              {
//                 result += text; 
//              }
//     return result;
// }
// string Ya=Metod4(3,"кристина");
// Console.WriteLine(Ya);

//цикл в цикле, сторим таблицу умножения

//for (int i = 2; i <= 10; i++)
//{
   // for (int j = 2; j <=10; j++)
    // {
    //     Console.WriteLine($"{i}* {j}= {i*j}"); // интерполяция строк
    // }
    // Console.WriteLine();

//}

// отрабатываем методы и цикл фор, работой с текстом
//дан текст, в нем надо все пробелы заменить черточками, маленькие к большими К, большие С маленькими с

// string text= "-Я думаю, - сказал князь, улыбаясь, - что,"
//              + " ежели бы вас послали вместо нашего милого Винценгероде,"
//              + " вы бы взяли приступом согласие прусского короя."
//              + "Вы так кроасноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result=String.Empty;
//     int length=text.Length;
    // for (int i = 0; i < length; i++)
    // {
    //     if(text[i]==oldValue) result+= $"{newValue}";
    //     else result+= $"{text[i]}";
    // }

    // return result;
//}
// string newText=Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText=Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText=Replace(newText, 'с','С');
// Console.WriteLine(newText);

//один из методов упорядочения массива это Сортировка выбором 
// ее алгоритм: 
//берем самое первое число и находим минимальное в оставшейся части, поменять их местами,
// берем второе число, опять находим минимальный в оставшейся части и меняем их местами и т д

// int[] arr= { 1,5,8,0,53,7,};
// void PrintArray(int[] array)
// {
//     int count=array.Length;
//         for (int i = 0; i < count; i++)
//             {
//                  Console.Write($"{array[i]} ");
//             }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length-1; i++)
//     {
//         int minPosition=i;
//         for (int j = i+1; j < array.Length; j++)
//         {
//             if(array[j]<array[minPosition]) minPosition=j;
//         }

//         int temp=array[i];
//         array[i]=array[minPosition];
//         array[minPosition]=temp;

//     }
// }


// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);

// а теперь переделаем, чтобы упорядочивал от макс к мин

int[] arr= { 1,5,8,0,53,7,};
void PrintArray(int[] array)
{
    int count=array.Length;
        for (int i = 0; i < count; i++)
            {
                 Console.Write($"{array[i]} ");
            }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int maxPosition=i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j]>array[maxPosition]) maxPosition=j;
        }

        int temp=array[i];
        array[i]=array[maxPosition];
        array[maxPosition]=temp;

    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);







