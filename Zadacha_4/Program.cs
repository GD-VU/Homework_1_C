Console.Clear();

//ввести три числа, вывести максимальное
int a, b, c, count = 0, max=0;

Console.Write("Введите первое число для сравнения: ");
int.TryParse(Console.ReadLine(), out a);
Console.Write("Введите второе число для сравнения: ");
int.TryParse(Console.ReadLine(), out b);
Console.Write("Введите третье число для сравнения: ");
int.TryParse(Console.ReadLine(), out c);
if ((a!=b) && (b!=c) && (a!=c) && (a>0) && (b>0) && (c>0))
{
    while (count <3)
    {
        if (a>max) max = a;
        if (b>max) max = b;
        if (c>max) max = c;
        count++;
    }
    
    Console.Write("Max: " + max);
}
else
{
    Console.WriteLine("Oops");
}