/*
// Задача на разворот массива
int [] ReverseArray(int[] array)
{
    int temp;
    int j = array.Length - 1;

    for(int i = 0; i < array.Length / 2; i++, j--)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    return array;
}
*/
/*
// Альтернативная запись через while
int [] ReverseArray(int[] array)
{
    int temp;
    int j = array.Length - 1, i = 0;

    while(i < j)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;

        i++;
        j++;
    }

    return array;
}
*/
/*
int[] myArray = {2, 4, 6, 8};
myArray = ReverseArray(myArray);

for(int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}
*/

// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.


// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
