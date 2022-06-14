// TASK 1
/*
bool PalindromeOrNot(int number)
{
    return (number / 10000 == number % 10 && (number / 1000) % 10 == (number % 100) / 10);
}

Console.Write("Enter any five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

while(number < 10000 && number > -10000 ^ number > 99999 ^ number < -99999)
{
    Console.Write("You entered not five-digit number. Please try again: ");
    number = Convert.ToInt32(Console.ReadLine());
}

if(PalindromeOrNot(number)) Console.WriteLine("This number is palindrome");
else Console.WriteLine("This number is not palindrome");
*/
// TASK 2
/*
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
Console.WriteLine($"Length between point A and point B in 3D space is {length}");
*/

// TASK 3
/*
void Cube (int N)
{
    int current = 1;
    while(current <= N)
    {
        Console.Write(Math.Pow((current), 3) + " ");
        current ++;
    }

}

Console.Write("Enter natural number N: ");
int N = Convert.ToInt32(Console.ReadLine()); 
while(N < 1)
{
    Console.Write("This program works only with natural numbers. Please enter number N again: ");
    N = Convert.ToInt32(Console.ReadLine());
}

Cube(N);
*/