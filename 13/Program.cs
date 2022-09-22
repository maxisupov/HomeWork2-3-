// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int i = 100;

if (num < 100)  
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    if ((num > 99) && (num < 1000))
    {
        Console.WriteLine($"Третья цифра {(num % i) % 10}");
    }
    else 
    {
        if ((num > 999) && (num < 10000))
        {
            Console.WriteLine($"Третья цифра {(num / 10) % 10}");
        }
        else
        {
            if ((num > 9999) && (num < 10000))
            {
                Console.WriteLine($"Третья цифра {(num / 100) % 10}");
            }
            else
            {
                if ((num > 99999) && (num < 100000));
                {
                    Console.WriteLine($"Третья цифра {(num / 1000) % 10}");
                }
            }
            
        }
        
        
    }
}