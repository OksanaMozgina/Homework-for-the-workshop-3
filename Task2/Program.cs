/*
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

void GetDistanceBetweenTwoPoints(int firstX, int secondX, int firstY, int secondY, int firstZ, int secondZ)
{
    double result = 0;

    int tempX = (secondX - firstX) * (secondX - firstX);
    int tempY = (secondY - firstY) * (secondY - firstY);
    int tempZ = (secondZ - firstZ) * (secondZ - firstZ);

    result = Math.Sqrt(tempX + tempY + tempZ);
    
    Console.WriteLine($"расстояние между двумя точками = {result}");
}

GetDistanceBetweenTwoPoints(7,1,-5,-1,0,9);