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
    while(num < 1);
   
    return num;
}

// TASK 1

int[,] AscendingRows(int[,] array)
{
    int temp;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if(array[i, j] > array[i, j + 1])
            {
                temp = array[i, j +1];
                array[i, j + 1] = array[i, j];
                array[i, j] = temp;
                j = -1;
            }
        }
    }

    return array;
}

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
