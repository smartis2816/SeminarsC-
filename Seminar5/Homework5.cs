// Метод для создания рандомного массива
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

/*
// TASK 1
// Метод для нахождения кол-ва чётных чисел в массиве
int HowManyEvenNums(int[] array)
{
    int index;
    int quatity = 0;
    for(index = 0; index < array.Length; index++)
    {
        if(array[index] % 2 == 0) quatity++;
    }
    return quatity;
}

int min = 100;
int max = 999;
int size = new Random().Next(5, 101);

Console.WriteLine("This is array:");
int[] newArray = CreateRandomArray(size, min, max);

Console.WriteLine($"Quantity of even numbers in this array is {HowManyEvenNums(newArray)}");
*/

// TASK 2
// Метод для нахождения суммы элементов с нечётными позициями в массиве
/*
int FindSumOfOddPositions(int[] array)
{
    int index;
    int sum = 0;
    for(index = 1; index < array.Length; index += 2)
    {
        sum += array[index];
    }
    return sum;

}

Console.WriteLine("This is array:");
int[] newArray2 = CreateRandomArray(6, 1, 10);
Console.WriteLine($"Summary of numbers with odd indexes is {FindSumOfOddPositions(newArray2)}");
*/

// TASK 3
// Метод для создания массива с вещественными числами
double[] RandomDoubleArray(int size)
{
    double[] newArray = new double[size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
    {
        newArray[i] = rnd.NextDouble();
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

// Нахождение масимального числа в массиве
double FindMax(double[] array)
{
    double maxEl = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(maxEl < array[i]) maxEl = array[i];
    }
    return maxEl;
}

// Нахождение минимального числа в массиве
double FindMin(double[] array)
{
    double minEl = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(minEl > array[i]) minEl = array[i];
    }
    return minEl;
}

Console.WriteLine("This is array:");
double[] newArray3 = RandomDoubleArray(4);
double Subtraction = FindMax(newArray3) - FindMin(newArray3);
Console.WriteLine($"Subtraction between max and min numbers in array is {Subtraction}");
