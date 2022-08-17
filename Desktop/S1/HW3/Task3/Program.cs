// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
string GiveMeCube(int number){
    string res = "";
    for (int i = 1; i<=number; i++){
     res += $"{Math.Pow(i,3)}  ";
    }
    return res;
}
var input = Convert.ToInt32(Console.ReadLine());
var p = GiveMeCube(input);
Console.WriteLine(p);
