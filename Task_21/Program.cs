// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double DistanceToDot(int X1,int Y1,int Z1,int X2,int Y2,int Z2)
{
    double result = Math.Pow(X1 - X2,2) + Math.Pow(Y1 - Y2,2) + Math.Pow(Z1 - Z2,2);
    result = Math.Sqrt(result);
    return result;
}


System.Console.WriteLine("Введите координаты первой точки по оси X");
int X1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты первой точки по оси Y");
int Y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты первой точки по оси Z");
int Z1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты второй точки по оси X");
int X2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты второй точки по оси Y");
int Y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты второй точки по оси Z");
int Z2 = Convert.ToInt32(Console.ReadLine());

double result = DistanceToDot( X1, Y1, Z1, X2, Y2, Z2);
System.Console.WriteLine(String.Format("{0:0.00}",result));