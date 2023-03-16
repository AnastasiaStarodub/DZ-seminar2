// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 99999)
{
    Console.WriteLine("Введите другое число!");
}
else
{
    if (N < 100)
       Console.WriteLine("Третьей цифры в заданном числе нет!");
    else if (N < 1000)
       Console.WriteLine($"Третья цифра в числе - {N % 10}");
    else if (N < 10000)
       Console.WriteLine($"Третья цифра в числе - {N / 10 % 10}");
    else 
       Console.WriteLine($"Третья цифра в числе - {N / 100 % 10}");
}


