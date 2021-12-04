// 22. Найти расстояние между точками в пространстве 2D/3D
//2D
// double Pifagor(double x1, double x2, double y1, double y2)
// {
//     double AB=x2-x1;
//    double  CB=y2-y1;
//    double gip= Math.Pow(AB, 2) + Math.Pow(CB, 2);
//     double AC=Math.Sqrt(gip);
//     return AC;
// }
// Console.WriteLine("введите 4 числа, координаты 2 точек");

// double a1=Convert.ToDouble(Console.ReadLine());
// double a2=Convert.ToDouble(Console.ReadLine());
// double b1=Convert.ToDouble(Console.ReadLine());
// double b2=Convert.ToDouble(Console.ReadLine());

// double gipotenusa =Pifagor(a1, a2, b1, b2);
// Console.WriteLine(gipotenusa);

//3D
Console.WriteLine("введите 6 чисел, координаты 3 точек");

double x1=Convert.ToDouble(Console.ReadLine());
double x2=Convert.ToDouble(Console.ReadLine());
double y1=Convert.ToDouble(Console.ReadLine());
double y2=Convert.ToDouble(Console.ReadLine());
double z1=Convert.ToDouble(Console.ReadLine());
double z2=Convert.ToDouble(Console.ReadLine());

double gip= Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2);
double gipotenusa=Math.Sqrt(gip);
Console.Write("расстояние между 2 точками =");
Console.Write(gipotenusa);