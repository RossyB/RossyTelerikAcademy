namespace GenericClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TestGenericClass
    {
        public static void Main()
        {
            var myListInt = new GenericList<int>();

            myListInt.Add(2);
            myListInt.Add(5);
            myListInt.Add(16);
            myListInt.Add(78);
            myListInt.Add(52);
            myListInt.Add(9);

            Console.WriteLine("Min element in list is: {0}", myListInt.Min());
            Console.WriteLine();
            Console.WriteLine("Max element in list is: {0}", myListInt.Max());
            Console.WriteLine();

            var myListString = new GenericList<string>();

            myListString.Add("Ivan");
            myListString.Add("Petar");
            myListString.Add("Georgi");
            myListString.Add("Todor");
            myListString.Add("Stoyan");

            Console.WriteLine(myListString[4]);
            Console.WriteLine();

            Console.WriteLine(myListString.ToString());
            Console.WriteLine();

            myListString[4] = "Soyancho";

            myListString.Insert(3, "Angel");

            Console.WriteLine(myListString.ToString());

            Console.WriteLine();

            myListString.Delete(1);

            Console.WriteLine(myListString.ToString());
            Console.WriteLine();

            myListString.Clear();

            Console.WriteLine(myListString.ToString());
            Console.WriteLine();
        }
    }
}
