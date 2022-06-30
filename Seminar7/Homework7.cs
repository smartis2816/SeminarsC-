/*
// TASK 1
// Метод для создания рандомного двумерного массива с вещественными числами
double[,] CreateDoubleRandomTwoDemArray(int m, int n, double min, double max)
{
    double[,] newMatrix = new double[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            newMatrix[i, j] = new Random().NextDouble() * (max - min) + min;

    return newMatrix;
}

// Метод для выведения массива на экран
void ShowDoubleTwoDimArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j], 2) + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Enter the number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter minimum possible value of numbers: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter maximum possible value of numbers: ");
double max = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

double[,] NewArray = CreateDoubleRandomTwoDemArray(m, n, min, max);
ShowDoubleTwoDimArray(NewArray);
*/

// TASK 2
// Этот метод создаёт двумерный массив 
int[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a, b];

    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            newMatrix[i, j] = new Random().Next(min, max - 1);

    return newMatrix;
}

// Метод выводит массив на экран
void ShowTwoDimArray(int[,] array)
{
    Console.WriteLine("This is array:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Метод показывает значение указанного элемента или говорит, что такого элемента нет
string GetValueOfElement(int[,] array, int M, int N)
{
    if((M > array.GetLength(0) - 1 || M < 0) 
    || (N > array.GetLength(1) - 1 || N < 0))   return "There are no elements with such indexes";
    else    return "Value is " + Convert.ToString(array[M, N]);
}

// Метод для запроса у пользователя кол-ва строк или столбцов
int RowsOrColumnsRequest()
{
    int num;

    do
    {
        Console.Write("Value of quantity must be natural number. Enter the number: ");
        num = Convert.ToInt32(Console.ReadLine());
    }
    while(num < 1);
   
    return num;
}
/*
Console.Write("Rows. ");
int m = RowsOrColumnsRequest();
Console.Write("Columns. ");
int n = RowsOrColumnsRequest();
Console.WriteLine("Enter minimum and maximum possible values of numbers in array: ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandomTwoDemArray(m, n, min, max);
ShowTwoDimArray(newArray);

Console.Write("Enter index of the element by rows: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter index of the element by columns: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine(GetValueOfElement(newArray, M, N));
*/

// TASK 3
// Метод для нахождения среднего арифметического столбцов
void ArithmeticMeanColumns(int[,] array)
{
    double ArithmeticMean;
    double sum;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        
    ArithmeticMean = sum / array.GetLength(0);
    Console.Write($"Sum of the column is {sum}. ");
    Console.Write($"Arithmetic mean is {Math.Round(ArithmeticMean, 2)}");
    Console.WriteLine();
    } 
}
/*
Console.Write("Rows. ");
int m = RowsOrColumnsRequest();
Console.Write("Columns. ");
int n = RowsOrColumnsRequest();
Console.WriteLine("Enter minimum and maximum possible values of numbers in array: ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandomTwoDemArray(m, n, min, max);
ShowTwoDimArray(newArray);
ArithmeticMeanColumns(newArray);
*/