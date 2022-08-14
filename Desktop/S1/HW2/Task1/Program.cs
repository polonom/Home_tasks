Console.Clear();
int ShowMeSecondNumber(int number)
{
int n = (number/10)%10;
Console.WriteLine($"Второе число - {n}");
return n;
}
var input = Convert.ToInt32(Console.ReadLine());
if (input>999|input<100){
    Console.WriteLine("Введите трехзначное число!");
}
else{
    var n = ShowMeSecondNumber(input);
}
