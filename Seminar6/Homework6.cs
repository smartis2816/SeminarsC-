
/*
// TASK 1
// Метод для нахождения в массиве количества чисел больше 0.
int HowManyPositiveNums(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
}

// Метод для создания пользовательского массива из целых чисел.
int[] CreateUserArray()
{
    Console.Write("Enter how many integer numbers will you input: ");
    int M = Convert.ToInt32(Console.ReadLine());
    
    int[] userArray = new int[M];
    Console.Write("Enter the first integer number: ");
    userArray[0] = Convert.ToInt32(Console.ReadLine());

    for(int i = 1; i < M; i++)
    {
        Console.Write("Enter the next integer number: ");
        userArray[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine();
    Console.Write("Here are the numbers you entered: ");

    for(int i = 0; i < M - 1; i++)
    {
        Console.Write(userArray[i] + ", ");
    }
    Console.Write(userArray[M - 1] + ".");
    
    Console.WriteLine();

    return userArray;
}


int[] newArray = CreateUserArray();
Console.WriteLine();

Console.WriteLine($"You entered {HowManyPositiveNums(newArray)} positive numbers.");
*/

// TASK 2

// Метод для создания рандомного массива
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

// Метод для поэлементного копирования массива через for
int[] CopyArray(int[] array)
{
    int[] CopyOfArray = new int[array.Length];
    for (int i = 0, j = 0; i < array.Length; i++, j++)
    {
        CopyOfArray[j] = array[i];
        Console.Write(CopyOfArray[j] + " ");
    }
    return CopyOfArray;
}

/*
// Метод для поэлементного копирования массива через while
int[] CopyArray(int[] array)
{
    int[] CopyOfArray = new int[array.Length];
    int i = 0, j = 0;
    while(i < array.Length)
    {
        CopyOfArray[j] = array[i];
        Console.Write(CopyOfArray[j] + " ");
        i++;
        j++;
    }
    return CopyOfArray;
}
*/

Console.Write("Enter the length of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter minimum possible value of numbers: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter maximum possible value of numbers: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("This is original array:");
int[] OriginalArray = CreateRandomArray(size, min, max);
Console.WriteLine();
Console.WriteLine("This is copy of original array:");
int[] CopiedArray = CopyArray(OriginalArray);