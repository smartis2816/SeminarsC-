// Найти суммы положительных и отрицательных элементов массива

/*
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

int FindPositiveSum(int[] array)
{
    int sum = 0;
    int i;
    for(i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum += array[i];
    }

    return sum;
}

int FindNegativeSum(int[] array)
{
    int sum = 0;
    int i;
    for(i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sum += array[i]; // sum = sum + array[i];
    }

    return sum;
}

int[] myArray = CreateRandomArray(12, -9, 9);

Console.WriteLine("Sum of positive numbers is " + FindPositiveSum(myArray));
Console.WriteLine("Sum of negative numbers is " + FindNegativeSum(myArray));
*/
/*
// Этот метод общий для всех задач, нужен для создания рандомного массива
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

// 1. положительные элементы замените на соответствующие отрицательные, и наоборот
int[] ReverseElements(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

// 2. Напишите программу, которая определяет, присутствует ли заданное число в массиве
bool FindNumber(int[] array, int num){
    int i;
    for(i = 0; i < array.Length; i++){
        if(array[i] == num) return true;
    }
    return false;
}

// 3. массив из 12 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]
int FindQuantityOfElementsInRange(int[] array, int min, int max)
{
    int count = 0;
    int i;
    for(i = 0; i < array.Length; i++)
    {
        if(array[i] >= min && array[i] <= max) count++;
    }
    return count;
}

// Вывод на экран результирующего метода
String OutputArrayConsole(int[] array)
{
    string CommaAndSpace = "";
    int i;
    for(i = 0; i < array.Length; i++)
    {
        CommaAndSpace += array[i] + ", ";
    }
    return CommaAndSpace;
}

// Программа
// Задаём массив
Console.WriteLine("This is array: ");
int[] newArray = CreateRandomArray(12, -11, 111);

// Задача 1
Console.WriteLine($"Reverse array {OutputArrayConsole(ReverseElements(newArray))}");

// Задача 2
int num = 17;
Console.WriteLine($"Ищем число {num}");
Console.WriteLine("В массиве число " + num + ( (FindNumber(newArray, num)) ? " присутствует" : " не присутствует" ));

// Задача 3
int min = 10;
int max = 99;
Console.WriteLine($"В массиве количество цифр в промежутке от {min} до {max} составляет {FindQuantityOfElementsInRange(newArray, min, max)}");
*/


