/*
int FindQuart(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;

    return -1;
}

int result = FindQuart(2, 4);

if(result == -1) Console.WriteLine("Данная точка расположена на осях");
else Console.WriteLine($"Точка находится в {result} четверти");
*/
/*
void Quad(int num)
{
    int current = 1;
    while(current <= num)
    {
        Console.Write((current * current) + " ");
        current ++;
    }
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Quad(num);
*/
/*
double FindLength(double xA, double yA, double xB, double yB)
{
    return Math.Sqrt((xB - xA) * (xB - xA) + Math.Pow((yB - yA), 2));
}
*/