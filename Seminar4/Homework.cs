
// TASK 1
/*
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
*/

/*
double RaisePower(double A, double B)
{
    double count = 2;
    double result = A;
    while(count <= B)
    {
        result = result * A;
        count++;
    }
    return result;
}

Console.Write("Enter number A: ");
double A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number B: ");
double B = Convert.ToInt32(Console.ReadLine());

if(B < 1) B = B * (-1);

Console.WriteLine($"{A}^{B} = {RaisePower(A, B)}");
*/

// TASK 2
// Option 1 - программа генерирует числа
/*
int size = 8;
int[] newArray = new int[size];

for(int i = 0; i < size; i++)
{
    newArray[i] = new Random().Next(0, 9);
}

for(int i = 0; i < size; i++)
{
    Console.Write(newArray[i] + " ");
}
*/

// Option 2 - пользователь вводит числа
/*
int size = 8;
int[] newArray = new int[size];

for(int i = 0; i < size; i++)
{
    Console.Write("Enter any number to fill the array: ");
    newArray[i] = Convert.ToInt32(Console.ReadLine());
}

for(int i = 0; i < size; i++)
{
    Console.Write(newArray[i] + " ");
}
*/