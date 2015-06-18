namespace SubstringForStringBuilder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class StringBuilderTest
    {
        static void Main()
        {
            StringBuilder test = new StringBuilder();

            test.Append("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique luctus nunc quis egestas. Phasellus dictum aliquam ligula, id bibendum urna faucibus in. Ut suscipit rhoncus sagittis. Aenean varius, mauris a blandit venenatis, nunc nibh rutrum erat, id accumsan eros ipsum id lacus. Praesent sodales a nisi eget ultrices. Maecenas mauris erat, ultricies eget scelerisque ac, blandit et est. Ut et laoreet nisl. Etiam consectetur velit ut felis vestibulum imperdiet.");

            test = test.Substring(22, 60);

            Console.WriteLine(test);
        }
    }
}
