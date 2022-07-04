/*
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
// Метод для запроса у пользователя кол-ва строк или столбцов
int RowsOrColumnsRequest()
{
    int num;

    do
    {
        Console.Write("Value of quantity must be natural number. Enter the number: ");
        num = Convert.ToInt32(Console.ReadLine());
    }
    while (num < 1);

    return num;
}

// TASK 1
// Упорядочивание элементов в строках по возрастанию
int[,] AscendingRows(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (array[i, j] > array[i, j + 1])
            {
                temp = array[i, j + 1];
                array[i, j + 1] = array[i, j];
                array[i, j] = temp;
                j = -1;
            }
        }
    }

    return array;
}
*/
/*
Console.Write("Rows. ");
int m = RowsOrColumnsRequest();
Console.Write("Columns. ");
int n = RowsOrColumnsRequest();
Console.WriteLine("Enter minimum and maximum possible values of numbers in array: ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArrayTask1 = CreateRandomTwoDemArray(m, n, min, max);
ShowTwoDimArray(newArrayTask1);
AscendingRows(newArrayTask1);
Console.WriteLine("Modified array.");
ShowTwoDimArray(newArrayTask1);
*/
/*
// TASK 2
// Метод для запроса размера матрицы и проверки введённых чисел
int[] RectangularArrayRequest()
{
    int N, M;
    int[] array = new int[2];
    do
    {
        Console.WriteLine("Matrix must be Rectangular. Quantity of rows and columns must be different.");
        Console.WriteLine("Input numbers: ");
        N = Convert.ToInt32(Console.ReadLine());
        M = Convert.ToInt32(Console.ReadLine());
    }
    while (N < 1 || M < 1 || N == M);
    array[0] = N;
    array[1] = M;
    return array;
}
// Находит суммы элементов строк и записывает в массив
int[] FindSumsRows(int[,] array)
{

    int[] Sums = new int[array.GetLength(0)];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            Sums[k] = sum;
        }
        k++;
    }
    return Sums;
}
// Находит элемент с минимальным значением в массиве
int FindRowWithMinSum(int[] array)
{
    int min = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[min] > array[i]) min = i;
    }

    return min;
}
// Выводит на экран двумерный массив + суммы строк + строку с мин. суммой   
void ShowArraySumsAndMinRow(int[,] array, int[] array2, int minRow)
{
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"Row №{k + 1}: ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(" ->  The sum of the row is " + array2[k]);
        k++;
    }
    Console.WriteLine();
    Console.WriteLine($"The sequence number of the row with the minimum sum is {minRow + 1}");
    Console.WriteLine();
}
*/
/*
int[] Indexes = RectangularArrayRequest();
int m = Indexes[0];
int n = Indexes[1];
Console.WriteLine("Enter minimum and maximum possible values of numbers in array: ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArrayTask2 = CreateRandomTwoDemArray(m, n, min, max);
ShowTwoDimArray(newArrayTask2);

int[] SumsOfRows = FindSumsRows(newArrayTask2);
int minRow = FindRowWithMinSum(SumsOfRows);
ShowArraySumsAndMinRow(newArrayTask2, SumsOfRows, minRow);
*/
/*
// TASK 3
// Первый вариант метода
int[,] Spiral(int n)
{
    int[,] Matrix = new int[n, n];
    int current = 1;
    int count = n;
    int num = 0;
    do
    {
        for(int j = num; j < count; j++) // вправо
        {
            Matrix[num, j] = current;
            current ++;
        }
        count--;
        for(int i = n - count; i < count + 1; i++) // вниз
        {
            Matrix[i, count] = current;
            current ++;
        }
        for(int j = count - 1; j > num - 1; j--) // влево
        {
            Matrix[count, j] = current;
            current ++;
        }
        count--;
        for(int i = count; i > num; i--) // вверх
        {
            Matrix[i, num] = current;
            current ++;
        }
        num++;
        count++;
    }
    while(count > 0);

    return Matrix;
}
*/
/*
// Второй вариант метода
int[,] Spiral(int n)
{
    int[,] Matrix = new int[n, n];
    int current = 1;
    int count = n;
    int num;
    int getIndex = -1;
    do
    {
        num = 1;
        for (int j = 0; j < count; j++)
        {
            getIndex += num;
            Matrix[getIndex / n, getIndex % n] = current;
            current ++;
        }
        count--;
        num = n;
        for (int i = 0; i < count; i++)
        {
            getIndex += num;
            Matrix[getIndex / n, getIndex % n] = current;
            current ++;
        }
        num = -1;
        for (int j = 0; j < count; j++)
        {
            getIndex += num;
            Matrix[getIndex / n, getIndex % n] = current;
            current ++;
        }
        count--;
        num = -n;
        for (int i = 0; i < count; i++)
        {
            getIndex += num;
            Matrix[getIndex / n, getIndex % n] = current;
            current ++;
        }
    }
    while (count > 0);

    return Matrix;
}
*/
/*
int n = 7;
int[,] newArray = Spiral(n);
ShowTwoDimArray(newArray);
*/
