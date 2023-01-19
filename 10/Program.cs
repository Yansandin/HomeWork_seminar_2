Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int FirstDigit = number % 100;
int SecondDigit = FirstDigit / 10;

Console.WriteLine("Вторая цифра числа " + SecondDigit);