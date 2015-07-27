namespace Methods
{
    using System;

    public class TestMethod
    {
        public static void Main()
        {
            Console.WriteLine(Methods.CalcTriangleArea(3, 4, 5));

            Console.WriteLine(Methods.TranslateDigitInEnglish(5));
            
            Console.WriteLine(Methods.FindMaxElement(5, -1, 3, 2, 14, 2, 3));
            
            Methods.PrintNumber(1.3, "f");
            Methods.PrintNumber(0.75, "%");
            Methods.PrintNumber(2.30, "r");

            Console.WriteLine(Methods.CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + Methods.IsLineHorizontal(-1, 2.5));
            Console.WriteLine("Vertical? " + Methods.IsLineVertical(3, 3));

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
