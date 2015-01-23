using System;

class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        Console.Write("Enrer point x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enrer point y: ");
        double y = double.Parse(Console.ReadLine());

        double circleRadius = 1.5;
        double circleCenterX = 1;
        double circleCenterY = 1;



        bool isInCircle = ((x - circleCenterX) * (x - circleCenterX)) + ((y - circleCenterY) * (y - circleCenterY)) <= circleRadius * circleRadius;
        bool isOutsideRectangle = (-1 < x) ^ (x > 5) ^ (-1 < y) ^ (y > 1);


        if (isInCircle == true && isOutsideRectangle == true)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

    }
}
