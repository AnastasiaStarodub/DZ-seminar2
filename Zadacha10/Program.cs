// Программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 100 | N > 999)
{
    Console.WriteLine("Введите трехзначное число!");
}
else
{
    int num = N / 10;
    Console.WriteLine($"Вторая цифра числа - {num % 10}");
}
