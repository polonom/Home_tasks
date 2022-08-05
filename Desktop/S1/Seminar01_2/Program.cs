Console.Clear();
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (max<numberB) max=numberB;
if(max<numberC) {max = numberC;}
Console.WriteLine(max);

