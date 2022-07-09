// Метод для создания массива строк
string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        words[i] = Console.ReadLine();
    }

    return words;
}
// Вывод массива строк на экран
void ShowStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

// TASK 1
// Считает кол-во элементов, у которых первый символ совпадает с первым символом другого массива
int HowManyLetters(string[] array1, string[] array2)
{
    int count = 0;

    for (int i = 0; i < array2.Length; i++)
        for (int j = 0; j < array1.Length; j++)
            if (array2[i][0] == array1[j][0]) count++;

    return count;
}
/*
string[] VowelLetters = {"a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "Y"};
Console.Write("Input size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] newArray = CreateStringArray(size);
Console.WriteLine();
ShowStringArray(newArray);
Console.WriteLine();
Console.WriteLine($"The number of elements starting with a vowel letter is {HowManyLetters(VowelLetters, newArray)}");
*/
// TASK 2

string[] RegroupedArray(string[] array)
{
    int i = 0;
    int j = 0;
    int size = array.Length / 2 + 1;
    string[] NewRegroupedArray = new string[size];
    
    while (i < array.Length - 1)
    {
        NewRegroupedArray[j] = array[i] + array[i + 1];
        i += 2;
        j++;
    }
        
    if (array.Length % 2 != 0) NewRegroupedArray[size - 1] = array[array.Length - 1];

    return NewRegroupedArray;
}

Console.Write("Input size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] newArray = CreateStringArray(size);
Console.WriteLine();
ShowStringArray(newArray);
Console.WriteLine();
ShowStringArray(RegroupedArray(newArray));
