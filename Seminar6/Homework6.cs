

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

