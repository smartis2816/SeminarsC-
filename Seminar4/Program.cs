// Нахождение суммы цифр числа
/*
int FindSumOfDigits(int num)
{
    int sum = 0;

    while(num > 0)
    {
        sum = sum + num % 10; // sum += num % 10 - то же самое
        num = num / 10; // num /= 10;
    }

    return sum;
}

int n = 234;
int result = FindSumOfDigits(n);

Console.WriteLine($"Сумма цифр в числе {n} равна {result}");
*/
/*
int FindSum(int A)
{
    int current = 1;
    int sum = 0;
    while(current <=A)
    {
        sum = sum  + current;
        current++;
    }
    return sum;
}

Console.Write("Enter number A: ");
int number = Convert.ToInt32(Console.ReadLine());
int summary = FindSum(number);
Console.WriteLine($"Sum of numbers from 1 to A is {summary}");
*/
/*
int FindMult(int A)
{
    int current = 1;
    int mult = 1;
    while(current <=A)
    {
        mult = mult  * current;
        current++;
    }
    return mult;
}

Console.Write("Enter number A: ");
int number = Convert.ToInt32(Console.ReadLine());
int multiplication = FindMult(number);
Console.WriteLine($"Sum of numbers from 1 to A is {multiplication}");
*/

// Примеры записи массива
// int[] array = {1, 2, 3};

// int size = 8;
// int[] array = new int[size];
/*
int size = 8;
int[] array = new int[size];

for(int i = 0; i < size; i++)  //for(int i = 0; i < size; i = i + 1)
{
    array[i] = new Random().Next(0,2);
}

for(int i = 0; i < size; i++)
{
    Console.Write(array[i] + " ");
}
*/