// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("ВВедите три числа");
int number1, number2, number3;
number1 = Convert.ToInt32(Console.ReadLine());
number2 = Convert.ToInt32(Console.ReadLine());
number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2 & number1 > number3 )
    {
        Console.WriteLine("Первое число больше и оно равно " + number1);
    }
if (number2 > number1 & number2 > number3 ) 
    {
        Console.Write("Второе число больше и оно равно " + number2);
    }
if (number3 > number2 & number3 > number1 ) 
    {
        Console.WriteLine("Третье число больше и оно равно " + number3);
    }
    
        
