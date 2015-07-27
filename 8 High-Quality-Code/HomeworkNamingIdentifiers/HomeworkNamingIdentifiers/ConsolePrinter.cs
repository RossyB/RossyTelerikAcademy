namespace HomeworkNamingIdentifiers
{
    using System;

    public class ConsolePrinter
    {
        private const int MaxCount = 6;

        public static void Main()
        {
            ConsolePrinter.Methods cp = new ConsolePrinter.Methods();

            cp.PrintBollValue(true);
        }

        public class Methods
        {
            public void PrintBollValue(bool bollVariable)
            {
                string variableAsString = bollVariable.ToString();
                Console.WriteLine(variableAsString);
            }
        }
    }
}
