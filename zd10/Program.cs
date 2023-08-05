// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 10: Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");

Console.Write("Введите 3х значное число:");
int num = Convert.ToInt32(Console.ReadLine());
if(num<100 || num >999)

{
    Console.WriteLine("введено не 3х значное число");
}
else
{
string S=Convert.ToString(num);

        Console.Write("2я цифра:");

        Console.WriteLine(S[1]);
    
}