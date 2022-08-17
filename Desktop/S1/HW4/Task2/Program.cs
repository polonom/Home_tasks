// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int GiveMeSum(int number)
{
    number=Math.Abs(number);
    int result = 0;
    result = number % 10;
    while (number >= 10)
    {
        number = number / 10;
        result += number % 10;
    }

    return result;
}
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумму цифр в числе = {GiveMeSum(N)}");