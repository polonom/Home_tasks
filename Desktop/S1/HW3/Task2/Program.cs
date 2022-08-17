// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
double FindDistance(double[] f , double[] s ){
    double R = Math.Sqrt( Math.Pow(f[0]-s[0],2)+Math.Pow(f[1]-s[1],2)+Math.Pow(f[2]-s[2],2));
    return R;
    }
double[] first = new double[3]{0,0,0};
for (int i = 0;i < 3;i++){
    Console.WriteLine("Введите координаты первой точки");
    first[i] = Convert.ToDouble(Console.ReadLine());
}
double[] second = new double[3]{0,0,0};
for (int j = 0; j < 3 ; j++){
    Console.WriteLine("Введите координаты второй точки");
    second[j] = Convert.ToDouble(Console.ReadLine());
}
string Dis= string.Format("{0:F2}",FindDistance(first,second));
Console.WriteLine($"Расстояне между данными точками - {Dis}");