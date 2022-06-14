
// c = a % b
// 5 % 2 -> 1
// 5 / 2 -> 2

// 1234 / 10 -> 123 - убирает младший разряд
// 1234 % 10 -> 4 - вычленяет младший разряд
// 1234 / 100 -> 12
// 1234 % 100 -> 34

// a = a / 10 <-> a /= 10 - то же самое

/*
int FindMaxPart(int num)
{
    int dec, ed;
    
    if(num >= 10 && num <= 99)
    {
        dec = num / 10;
        ed = num % 10;

        if(dec > ed)
        {
            return dec;
        }
        else
        {
            return ed;
        }

    }
    else
    {
        return -1;
    }

}

Console.Write("Input two-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = FindMaxPart(a);

if(result == -1)
{
    Console.WriteLine("Your number is not two-digit");
}
else
{
    Console.WriteLine($"Bigger number of {a} is {result}");
}
*/

/*
int CutNumber()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine($"Current number is {num}");

    int sot = num / 100;
    int ed = num % 10;

    int result = sot * 10 + ed;
    return result;
}

Console.WriteLine(CutNumber());
*/


/*
string IsAliquot(int num1, int num2)
{
    if(num2 % num1 == 0)
    {
        return "True";
    }
    else
    {
        return ("False, rest num is " + (num2 % num1));
    }
}
*/


/*
bool IsAliquot2(int num)
{
    //if(num % 23 == 0 && num % 7 == 0) return true;
    //else return false;

    return (num % 23 == 0 && num % 7 == 0);
}

if(IsAliquot2(int num)) Console.WriteLine("Число кратно");
else Console.WriteLine("Число не кратно");
*/