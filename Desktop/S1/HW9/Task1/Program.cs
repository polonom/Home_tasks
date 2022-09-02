Console.WriteLine("Введите первое число");
bool isNumberM = int.TryParse(Console.ReadLine(),out int m);
Console.WriteLine("Введите второе число");
bool isNumberN = int.TryParse(Console.ReadLine(),out int n);
if (isNumberM == false || isNumberN == false){
    Console.WriteLine("Введены не правельные данные");
    return;
}
void PrintNumbers(int n,int m){
    if (n<m){
        Console.Write($" {n} ");
    if (n==m) return;
    PrintNumbers(n+1,m);
    }
    else{
        Console.Write($" {m} ");
    if (n==m) return;
    PrintNumbers(n,m+1);
    }
    
}
PrintNumbers(n,m);