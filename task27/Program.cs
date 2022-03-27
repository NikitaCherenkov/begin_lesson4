// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
string entry = Convert.ToString(Console.ReadLine());
int num;
int sum = 0;
bool isNum = int.TryParse(entry, out num);
num = Math.Abs(num);
if (isNum) {
    while (num > 0) {
        sum = sum + num % 10;
        num = num / 10;
        Console.WriteLine($"{sum}");
    }
    Console.WriteLine($"Сумма цифр в числе: {sum}");
} else Console.WriteLine("Введено не число");
