Console.Write("Введите число- ");

int number = Convert.ToInt32(Console.ReadLine());

string thirdDigit = Convert.ToString(number);

if (thirdDigit.Length > 2)
{
  Console.WriteLine("Третья цифра -  " + thirdDigit[2]);
}
else 
{
  Console.WriteLine("Третьей цифры нет");
}