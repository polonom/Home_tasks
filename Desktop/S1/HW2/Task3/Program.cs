Console.Clear();
bool IsItWeekend(int number){
    if (number == 6 | number == 7){
        return true;
}
     else{
        return false;
     }
}
var input = Convert.ToInt32(Console.ReadLine());
 bool result = IsItWeekend(input);
 if (result == true){
    Console.WriteLine("Да, это выходной");
 }
 else{
     Console.WriteLine("Увы!");
 }
