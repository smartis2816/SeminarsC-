
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
    while(number < 100 && number > -100 ^ number > 999 ^ number < -999)
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

// TASK2
/*
int FindThirdDigit(int num)
{
    if(num < 100 && num > -100)
    {
        return -1;
    }
    else
    {
        while(num > 999 ^ num < -999)
        {
            num /= 10;
        }
        return num % 10;
    }
}
Console.Write("Input any number and console will show the third digit of this number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = FindThirdDigit(number);
if(result == -1)
{
    Console.WriteLine("The number you entered doesn't contain the third digit");
}
else
{
    Console.WriteLine($"The third digit of the number {number} is {result}");
}
*/

// TASK3
/*
bool WeekendOrNot(int num)
{
    return (num == 6 ^ num == 7);
}
Console.Write("Choose one of the days of the week from 1 to 7: ");
int DayOfWeek = Convert.ToInt32(Console.ReadLine());
while (DayOfWeek > 7 ^ DayOfWeek < 1)
{
    Console.Write("Wrong number. Please choose number of the day again: ");
    DayOfWeek = Convert.ToInt32(Console.ReadLine());
}
if (WeekendOrNot(DayOfWeek)) Console.WriteLine("This day is weekend");
else Console.WriteLine("This day is not weekend");
*/