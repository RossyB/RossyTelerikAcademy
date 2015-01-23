//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.


using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        //input
        Console.Write("Enter your weight: ");
        float weight = float.Parse(Console.ReadLine());

        //solution
        float moonWeight = weight * 0.17f;

        //print
        Console.WriteLine("Your weight on the Moon is: {0:F3}", moonWeight);
    }
}
