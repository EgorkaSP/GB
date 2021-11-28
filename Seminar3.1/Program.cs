// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int IndexOf(int[] collection, int find)
{
   int count=collection.Length;
   int index=0;
   int position=-1;

while(index < count)
{
    if(collection[index]==find)
        {
            position=index;

        }

   index++;
}
return position;
}

int[] Day_Of_The_Week={1,2,3,4,5,6,7};
Console.WriteLine("введите номер дня недели");
int day=int.Parse(Console.ReadLine());

int indexOfDay=IndexOf(Day_Of_The_Week, day );

    if(  Day_Of_The_Week[indexOfDay] >= 6 )
{
        Console.WriteLine("это выходной");
}
   {
    if(Day_Of_The_Week[indexOfDay]<6)
    Console.WriteLine("это будний день");
}

 



