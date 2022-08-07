// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("ВВедите число");
int N, i=1;
N = Convert.ToInt32(Console.ReadLine());
while (i < N+1)
{
    if (i % 2 ==0 )
    {
        Console.Write(" "+i);
    }
    i+=1;    
}
