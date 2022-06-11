
int FindSecondPart(int num)
{
    if(num >= 100 && num <= 999)
    {
        return (num / 10) % 10;
    }
    else
    return -1;
}

Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = FindSecondPart(number);
if(result == -1)
{
    Console.WriteLine("Your number is not three-digit");
}
else
{
    Console.WriteLine($"Second part of {number} is {result}");
}