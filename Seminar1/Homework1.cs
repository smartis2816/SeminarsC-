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