Console.Clear();
int? ShowMeNumberThree(int number){
if (number<100){
    Console.WriteLine("Третьей цифры нет!");
    return null;
}
while (number>999){
   number = number/10;
}
int m = number % 10;
Console.WriteLine($"Третья цифра - {m}");
return m;
}
var input = Convert.ToInt32(Console.ReadLine());
 var k = ShowMeNumberThree(input);
 

