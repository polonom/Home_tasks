// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
bool IsItPolindrom(string smt){
for (int i = 0 ; i < smt.Length/2 ; i++) {
    if (smt[i] != smt[smt.Length-i-1]) {
        return false;
    }
    else continue;
}
return true;
}
string input = Console.ReadLine();
var res = IsItPolindrom(input);
if (res == true) {
    Console.WriteLine($"{input}-палиндром");
}
else  Console.WriteLine($"{input}- не палиндром");
