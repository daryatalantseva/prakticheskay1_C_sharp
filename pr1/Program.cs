//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("ВВедите два числа");
int number1, number2;
number1 = Convert.ToInt32(Console.ReadLine());
number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
    {
        Console.WriteLine("Первое число больше, второе меньше");
    }
else
    {
        Console.Write("Второе число больше, первое меньше");
    }
        
