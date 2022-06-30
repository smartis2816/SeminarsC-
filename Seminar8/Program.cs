// Задача №1.
// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] CreateTwoDimArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < m; j++)
            array[i, j] = new Random().Next(min, max + 1);

    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

int[,] ChangeLines(int[,] array, int strIndex1, int strIndex2)
{
    int temp;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[strIndex1, j];
        array[strIndex1, j] = array[strIndex2, j];
        array[strIndex2, j] = temp;
    }

    return array;
}

/*
int[,] myArray = CreateTwoDimArray(4, 5, 1, 9);
ShowArray(myArray);
myArray = ChangeLines(myArray, 0, myArray.GetLength(0) - 1);
Console.WriteLine();
ShowArray(myArray);
*/

// Задача №2.
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


// Задача №3.
// Из двумерного массива целых чисел удалить строку и столбец,
// на пересечении которых расположен наименьший элемент (записать туда 0).


