/*
// Метод для создания рандомного двумерного массива
int[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a, b];

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            newMatrix[i, j] = new Random().Next(min, max + 1);
            Console.Write(newMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }

    return newMatrix;
}

// int[,] array = CreateRandomTwoDemArray(4,5,1,9);


//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
int[,] CreateArrayIJ(int a, int b)
{
    int[,] newMatrix = new int[a, b];

    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            newMatrix[i, j] = i + j;

    return newMatrix;
}

// Метод для выведения массива на экран
void ShowTwoDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
*/
/*
int[,] newArray = CreateArrayIJ(4, 5);
ShowTwoDimArray(newArray);
*/


//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
// Метод преобразует в квадраты элементы с чётными индексами
int[,] UpdateArrayEvenIndexQuad(int[,] array)
{
    int step = 2;
    for (int i = 2; i < array.GetLength(0); i += step)
        for (int j = 2; j < array.GetLength(1); i += step)
        {
            array[i, j] *= array[i, j];
        }

    return array;
}
*/
/*
int[,] myArray = CreateRandomTwoDemArray(4, 5, 1, 9);
Console.WriteLine();
UpdateArrayEvenIndexQuad(myArray);
ShowTwoDimArray(myArray);
*/

// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
/*
int SumOfDiagonal(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        sum += array[i, i];
    }
    return sum;
}
*/
