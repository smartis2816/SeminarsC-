// TASK 1

int FindSum(int N, int M)
{
    if(N <= M)
        return N + FindSum(N + 1, M);
    else return 0;
}
/*
Console.Write("Input ineger number N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Input ineger number M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Sum between {N} and {M} is {FindSum(N, M)}");
*/

// TASK 2

int HowManyDigits(int num)
{
    if(num / 10 != 0)   
        return 1 + HowManyDigits(num / 10);
    else 
        return 1;
}

Console.Write("Input ineger number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Quantuty of digits in number is {HowManyDigits(num)}");


