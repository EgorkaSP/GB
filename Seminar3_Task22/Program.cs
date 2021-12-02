// 22. Найти расстояние между точками в пространстве 2D/3D
//2D
double Pifagor(double x1, double x2, double y1, double y2)
{
    double AB=x2-x1;
   double  CB=y2-y1;
   double gip= Math.Pow(AB, 2) + Math.Pow(CB, 2);
    double AC=Math.Sqrt(gip);
    return AC;
}
Console.WriteLine("введите 4 числа, координаты 2 точек");

double a1=Convert.ToDouble(Console.ReadLine());
double a2=Convert.ToDouble(Console.ReadLine());
double b1=Convert.ToDouble(Console.ReadLine());
double b2=Convert.ToDouble(Console.ReadLine());

double gipotenusa =Pifagor(a1, a2, b1, b2);
Console.WriteLine(gipotenusa);

//3D



