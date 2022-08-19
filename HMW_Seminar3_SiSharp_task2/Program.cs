// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Hello, to determine the lengths of the segments between the points, follow the instructions.");
int xA = Coordinate("x", "A");
int yA = Coordinate("y", "A");
int zA = Coordinate("z", "A");
int xB = Coordinate("x", "B");
int yB = Coordinate("y", "B");
int zB = Coordinate("z", "B");
int Coordinate(string coorName, string pointName)
{
    Console.WriteLine($"Please enter the axis coordinate {coorName} point {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double Decision(double xA, double xB, double yA, double yB, double zA, double zB)
{
    return Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2));
}

double Lengthsegment = Math.Round(Decision(xA, xB, yA, yB, zA, zB), 2);
Console.WriteLine($"The length of the segment between the specified points will be {Lengthsegment} .");