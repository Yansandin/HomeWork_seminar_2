
int number = new Random().Next(100, 1000);

Console.WriteLine("Сгенерировано трехзначное число " + number);

int FirstDigit = number % 100;
int SecondDigit = FirstDigit / 10;

Console.WriteLine("Вторая цифра числа " + SecondDigit);