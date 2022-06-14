
double FindLengthIn3D (double xA, double yA, double zA, double xB, double yB, double zB)
{
    return Math.Sqrt(Math.Pow((xB-xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2));
}

Console.WriteLine("Enter the coordinates of the point A in 3D space: ");
Console.Write("xA = ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("yA = ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("zA = ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the coordinates of the point B in 3D space: ");
Console.Write("xB = ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("yB = ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("zB = ");
double zB = Convert.ToDouble(Console.ReadLine());

double length = FindLengthIn3D(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Length between point A and Point B in 3D space is {length}");