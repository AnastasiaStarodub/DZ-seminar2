// Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным

Console.Write("Введите порядковый номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 6)
    Console.Write("Это рабочий день");

else if (number > 5 && number < 8)
    Console.Write("Это выходной день");

else
    Console.Write("Введите число от 1 до 7");

    
 
