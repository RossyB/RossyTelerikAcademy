using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double n = double.Parse(Console.ReadLine());
        double s = double.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());

        double paperForStudents = n * s;

        decimal reams = (decimal)paperForStudents / 500;

        decimal costPaper = reams * p;

        Console.WriteLine("{0:F2}", costPaper);
    }
}
