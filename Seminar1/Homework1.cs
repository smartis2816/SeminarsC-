/*
// First task

int num1, num2;

Console.WriteLine("This program compares two numbers and tells which of them is max");

Console.Write("Input first number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine(num1 + " is max and " + num2 + " is min");
}
else
{
    Console.WriteLine(num2 + " is max and " + num1 + " is min");
}

*/

/*
// Second task

int num1, num2, num3, max;

Console.WriteLine("This program shows which of three numbers is max");

Console.Write("Input first number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third number: ");
num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    max = num1;
}
else
{
    max = num2;
}

if(max > num3)
{
    Console.WriteLine("Max number is " + max);
}
else
{
    max = num3;
    Console.WriteLine("Max number is " + max);
}

*/

/*
// Third task

int num;

Console.WriteLine("This program shows whether the number is even or odd");

Console.Write("Input number: ");
num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine(num + " is even number - true");
}
else
{
    Console.WriteLine(num + " is even number - false");
}
*/


/*
// Forth task

// Option 1

int N;
int current = 2;

Console.WriteLine("This program shows all even numbers from 1 to N");

Console.Write("Input number: ");
N = Convert.ToInt32(Console.ReadLine());

if(N == 1)
{
    Console.WriteLine("There are no even numbers from 1 to N");
}

while(current <= N)
{
    Console.Write(current + " ");
    current = current + 2;
}
*/

/*
// Option 2

int N;
int current;

Console.WriteLine("This program shows all even numbers from 1 to N");

Console.Write("Input number: ");
N = Convert.ToInt32(Console.ReadLine());

if(N == 0)
{
    Console.WriteLine("There are no even numbers from 1 to N");
}

if(N == 1)
{
    Console.WriteLine("There are no even numbers from 1 to N");
}

if(N == -1)
{
    Console.WriteLine("There are no even numbers from 1 to N");
}

if(N > 0)
{
    current = 2;
    while(current <= N)
    {
        Console.Write(current + " ");
        current = current + 2;
    }
    
}
else
{
    current = -2;
    while(current >= N)
    {
        Console.Write(current + " ");
        current = current - 2;
    }
}
*/