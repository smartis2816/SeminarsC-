// Задача 1
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int n)
{
    if(n != 1)
        ShowNums(n - 1);
    
    Console.Write(n + " ");
}

Console.Write("Input integer posotive nimber: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowNums(num);
*/
// Задача 2
// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNumsNM(int N, int M)
{
    if(N != M)
        ShowNumsNM(N - 1, M);

    Console.Write(N + " ");
}

Console.Write("Input maximum integer positive nimber: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimum integer positive nimber: ");
int M = Convert.ToInt32(Console.ReadLine());
ShowNumsNM(N, M);
*/
// Задача 3
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int SumDigits(int num)
{
    if(num == 0) 
        return 0;
        return num % 10 + SumDigits(num/10);
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumDigits(num));
*/
// Задача 4
// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
/*
double RaisePower(int A, int B)
{
    if (B > 0) 
        return A * RaisePower(A, B - 1);
    else if (B < 0)
        return 1/A * RaisePower(A, -B - 1);
    else
        return 1;
}

Console.Write("Input number: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(RaisePower(A, B));
*/