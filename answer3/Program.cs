//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

//void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("этот день выходной");
  }else if (dayNumber >= 1 && dayNumber <= 5 ) {
    Console.WriteLine("этот день не выходной");
  }else{
    Console.WriteLine("Вы ввели не верное значение");
  }

  