/*
 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double Distance3dSpace( int x1, int x2, int y1, int y2, int z1, int z2)
{
    int deltaX = x2 - x1;
    int deltaY = y2 - y1;
    int deltaZ = z2 - z1;
    double lengthsAB = Math.Sqrt(deltaX*deltaX + deltaY*deltaY + deltaZ*deltaZ);
    
    return lengthsAB;
}
Console.Write("Enter your X coord A; ");
int xAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your Y coord A; ");
int yAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your Z coord A; ");
int zAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your X coord B; ");
int xBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your Y coord B; ");
int yBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your Z coord B; ");
int zBcoord = Convert.ToInt32(Console.ReadLine());

double dist = Distance3dSpace(xAcoord,xBcoord,yAcoord,yBcoord,zAcoord,zBcoord);
Console.WriteLine($"Distance AB is {dist:f2}");