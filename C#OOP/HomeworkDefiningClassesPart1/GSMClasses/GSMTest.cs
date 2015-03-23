namespace GSMClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class GSMTest
    {
        static void Main()
        {
            var listOfGSM = new List<GSM>();

            GSM galaxy = new GSM("Galaxy S3", "Samsung", 540, "Ivan Ivanov",
                new Battery("2530SR", BatteryTypes.NiMH, 60, 15), new Display(5, 12000));

            GSM alcatel = new GSM("Pop D5", "Alcatel", 240, "Petar Ivanov",
                new Battery("1516TR", BatteryTypes.LiIon, 50, 10), new Display(4.5f, 10240));

            GSM lumia = new GSM("530 Lumia", "Nokia", 420, "Tania Ivanova",
                new Battery("1516TR", BatteryTypes.LiIon, 100, 15), new Display(4, 60000));

            listOfGSM.Add(galaxy);
            listOfGSM.Add(alcatel);
            listOfGSM.Add(lumia);

            foreach (var tel in listOfGSM)
            {
                Console.WriteLine(tel);
            }

            GSM.Iphone4s.Owner = "Petar Petrov";

            Console.WriteLine();
            Console.WriteLine("--------static Iphone--------");
            Console.WriteLine("Model: " + GSM.Iphone4s.Model);
            Console.WriteLine("Manifacturer: " + GSM.Iphone4s.Manifacturer);
            Console.WriteLine("Price: " + GSM.Iphone4s.Price);
            Console.WriteLine("Owner: " + GSM.Iphone4s.Owner);


            //GSM call history test
            GSM phone = new GSM("Pop D5", "Alcatel", 250, "Rossy Todorova");

            Console.WriteLine(new String('-', 35));
            phone.AddCall("0888728328", 320);
            phone.AddCall("0000000000", 560);
            phone.AddCall("0999909999", 210);
            phone.AddCall("0123456789", 130);

            int counter = 1;
            foreach (var call in phone.CallHistory)
            {
                Console.WriteLine("{0} call :", counter);
                Console.WriteLine("Duration --> {0} seconds", call.Duration);
                Console.WriteLine("Date and time of the call --> {0}", call.CallDateTime);
                Console.WriteLine("The dialed number --> {0}", call.DialledPhoneNumber);
                counter++;
            }
            Console.WriteLine(new String('-', 35));
            Console.WriteLine("Total price is : {0:0.00} leva", phone.CalculateTotalCallPrice((decimal)0.37));

            int index = FindLongestCall(phone);
            phone.DeleteCall(index);
            Console.WriteLine(new String('-', 35));
            Console.WriteLine("New total price is : {0:0.00} leva", phone.CalculateTotalCallPrice((decimal)0.37));

            phone.ClearCallHistory();
            counter = 0;
            Console.WriteLine(new String('-', 35));
            foreach (var call in phone.CallHistory)
            {
                Console.WriteLine("{0} call :", counter);
                Console.WriteLine("Duration --> {0} seconds", call.Duration);
                Console.WriteLine("Date and time of the call --> {0}", call.CallDateTime);
                Console.WriteLine("The dialed number --> {0}", call.DialledPhoneNumber);
            }
        }

        static int FindLongestCall(GSM phone)
        {
            int max = 0;
            int index = 0;
            for (int i = 0; i < phone.CallHistory.Count; i++)
            {
                if (phone.CallHistory[i].Duration > max)
                {
                    max = phone.CallHistory[i].Duration;
                    index = i;
                }
            }
            return index;
        }
    }
}
