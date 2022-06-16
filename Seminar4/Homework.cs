
// TASK 1

double RaisePower(double A, double B)
{
    return Math.Pow((A), B);
}

Console.Write("Enter number A: ");
double A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number B: ");
double B = Convert.ToInt32(Console.ReadLine());

if(B < 1) B = B * (-1);

Console.WriteLine($"{A}^{B} = {RaisePower(A, B)}");



// TASK 2


