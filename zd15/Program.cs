// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 15: Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
int num;
Console.Write("Введите  число:");
num = Convert.ToInt32(Console.ReadLine());

if(num>7|| num <1)

{
    Console.WriteLine("Число не не соотвесвует дню недели");
}
else
{

    if(num>5)Console.WriteLine("Входной день");
    else Console.WriteLine("Будний день");
}