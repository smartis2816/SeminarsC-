
// string[] names = {"Ivan", "Anna", "Max", "Denis"};
// Console.WriteLine(names[0][1]); - обращение к конкретному символу в строке
/*
string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        words[i] = Console.ReadLine();
    }

    return words;
}
*/
/*
void ShowStringArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
*/
/*
int NumberOfLongWords(string[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i].Length >= 5)
            count++;
    return count;
}
*/
/*
Console.Write("Input number of names: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] names = CreateStringArray(size);

Console.WriteLine("Number of long words is " + NumberOfLongWords(names));
*/

// Написать программу, которая принимает на вход два массива строк
// и возвращает массив из попарно объединенных исходных элементов.
/*
string[] ArrayCombination(string[] array1, string[] array2)
{
    int minsize;
    if(array1.Length > array2.Length)
    {
        minsize = array2.Length;
        for(int i = 0; i < minsize; i++)
            array1[i] += array2[i];
        return array1;
    }
    else
    {
        minsize = array1.Length;
        for(int i = 0; i < minsize; i++)
            array2[i] += array1[i];
        return array2;
    }
}
*/
/*
Console.Write("Input the size of the first array: ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the size of the second array: ");
int size2 = Convert.ToInt32(Console.ReadLine());
string[] array1 = CreateStringArray(size1);
string[] array2 = CreateStringArray(size2);
ShowStringArray(ArrayCombination(array1, array2));
*/
// Написать программу, которая считает 
// кол-во слов, начинающихся на букву Y или W.
/*
int SymbOfWords(string[] array, char a, char b)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i][0] == a || array[i][0] == b)
            count++;
    return count;
}
*/
/*
Console.Write("Input the size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the first symbol: ");
char a = Convert.ToChar(Console.ReadLine());
Console.Write("Input the second symbol: ");
char b = Convert.ToChar(Console.ReadLine());
string[] names = CreateStringArray(size);
Console.WriteLine(" " + SymbOfWords(names, a, b));
*/
