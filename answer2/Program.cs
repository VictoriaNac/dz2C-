//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Введите число:");
string s = Console.ReadLine();
string s1 = Convert.ToString (s[2]);

if (s.Length > 2)
{
    Console.WriteLine($"третья цифра {s1}");  
}else
{
    Console.WriteLine($"третья цифра отсутствует");
}



