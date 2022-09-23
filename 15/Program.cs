// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру, обозначающую день недели: ");
int Date = int.Parse(Console.ReadLine());

if ((Date >= 1) && (Date <= 5))
{
    Console.WriteLine("Будний день");
}
else
{
    if ((Date == 6) || (Date ==7))
    {
        Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("Такого дня недели не существует.");
    }
   
}