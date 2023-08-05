// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 13: Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");

Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
if(num >99)
{
        //string S=Convert.ToString(num);
        ;
        while (num>999)
        num=num/10;
       Console.Write("3я цифра:");
       Console.WriteLine(num%10); 
        //Console.WriteLine(S[2]);
}
else
{
Console.WriteLine("третьей цифры нет");    
}  