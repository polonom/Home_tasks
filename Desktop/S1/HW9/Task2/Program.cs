Console.WriteLine("Введите первое число");
bool isNumberM = int.TryParse(Console.ReadLine(),out int m);
Console.WriteLine("Введите второе число");
bool isNumberN = int.TryParse(Console.ReadLine(),out int n);
if (isNumberM == false || isNumberN == false){
    Console.WriteLine("Введены не правельные данные");
    return;
}
void GiveMeSumm(int m,int n,int summ=0){
    if (m<n){
         if (n==m) {
        summ=summ+m;
        Console.WriteLine($"Сумма чисел - {summ}");
        return;
        }
    summ = summ + m;
    GiveMeSumm(m+1,n,summ);
    }
    else{
         if (n==m) {
        summ=summ+n;
        Console.WriteLine($"Сумма чисел - {summ}");
        return;
        }
    summ = summ + n;
    GiveMeSumm(m,n+1,summ);
    }
   
    }
GiveMeSumm(m,n);