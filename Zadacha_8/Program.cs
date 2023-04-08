Console.Clear();

//ввод числа N и заполнение чисел до N четными
int N;

Console.Write("Введите число: ");
int.TryParse(Console.ReadLine(), out N);

for (int i = 2; i <= N; i=i+2)
{
    Console.Write(i + " ");
} 
