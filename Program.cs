/*Console.WriteLine("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] array = new int [m];

FillArray(array);
WriteArray(array);
int result = 0;
for (int i = 0; i < m; i++)
{
    if (array[i] > 0)
    {
        result++;
    }
}

Console.WriteLine($"Количество чисел > 0 равно " + result);

void FillArray(int[] array)
{
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        array[i] = number;
    }
}
void WriteArray(int[] array)
{
    for(int i = 0; i < m; i++)
    {
        Console.Write(array[i] + " "); 
    }
    Console.WriteLine();
}*/



double b1 = Cordinate("b1");
double k1 = Cordinate("k1");
double b2 = Cordinate("b2");
double k2= Cordinate("k2");


double x = -(b1 - b2)/(k1 - k2);
double y = k2 * x + b2;

Console.WriteLine("x = " + x + "; y = " + y);


double Cordinate(string x)
{
    Console.WriteLine($"Введите значение точки: {x}");
    double button = Convert.ToInt32(Console.ReadLine());
    return button;
}