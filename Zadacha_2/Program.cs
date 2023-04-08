Console.Clear();

//ввести два числа, вывести максимальное и минимальное число
int a, b, max=0, min=0;

Console.Write("Введите первое число для сравнения: ");
int.TryParse(Console.ReadLine(), out a);
Console.Write("Введите второе число для сравнения: ");
int.TryParse(Console.ReadLine(), out b);
if ((a!=b))
{
    if (a>b)
    {
        min = b;
        max = a;
    }
    else if (a<b)
    {
        min = a;
        max = b;
    }
    Console.Write("Max: " + max + " Min: " + min);
}
else
{
    Console.WriteLine("Oops");
}