Console.Clear();

//целочисленное деление. определение, является ли число четным
int a, ostatok;

Console.Write("Введите число для проверки четности: ");
int.TryParse(Console.ReadLine(), out a);

ostatok=a%2;
   
if (ostatok==0) 
{
    Console.WriteLine("Да, число четное");
}
else
{
    Console.WriteLine("Нет, число не четное");
}