Console.WriteLine("Введите первое число");
bool isNumberM = int.TryParse(Console.ReadLine(),out int m);
Console.WriteLine("Введите второе число");
bool isNumberN = int.TryParse(Console.ReadLine(),out int n);
if (isNumberM == false || isNumberN == false){
    Console.WriteLine("Введены не правельные данные");
    return;
}
int GiveMeAkkerman(int m,int n){
    if (m==0){
        return n+1;
    }
    else{
        if (m>0 && n==0){
        return GiveMeAkkerman(m-1,1);
        }
        else {
            return GiveMeAkkerman(m-1,GiveMeAkkerman(m,n-1));
        }
    
    }
   
}
int res = GiveMeAkkerman(m,n);
Console.WriteLine(res);