// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
double GiveMePower(int A, int B)
{
    double C = Math.Pow(A, B);
    return C;
}
Console.WriteLine("Какое число хотите возвести?");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В какую степень?");
int pow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GiveMePower(num, pow));
