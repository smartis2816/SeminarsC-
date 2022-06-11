
// TASK1
// Option 1 не запрашивает у пользователя ввод числа повторно в случае ошибки, а Option 2 - запрашивает


// Option 1
/*
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
*/


// Option 2
/*
int FindSecondPart()
{
    Console.Write("Input three-digit number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    while(number < 100 ^ number > 999)
    {
        Console.WriteLine("Your number is not three-digit");
        Console.Write("Input three-digit number: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    return (number / 10) % 10;
}
int result = FindSecondPart();
Console.WriteLine($"Second part of your number is {result}");
*/