﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //          Låt användaren mata in en mening.
            Console.WriteLine("Uppgift 1.1");
            Console.WriteLine("Please enter a line of text:");
            string userresponse;
            userresponse = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Thank you for entering: '{0}'", userresponse);

            //          Skriv ut antal ord
            Console.WriteLine();
            Console.WriteLine("Uppgift 1.2");
            //tanken, räkna antal mellanslag i meningen?
            int wordcount = 1; //dvs när ett space hittas är det ord 2
            //for (int i = 0; i < userresponse.Length; i++)
            //{
            //    if (userresponse[i] == ' ')
            //    {
            //        wordcount++;
            //    }
            //}
            //Hmm, jobbigt, kan man inte bara fråga string om den har ngt space?
            //ah, måste lära mig mer om string!
            foreach (char c in userresponse)
            {
                if (c == ' ')
                {
                    wordcount++;
                }
            }

            Console.WriteLine("Din mening har {0} ord.", wordcount);

//          Skriv ut varje ord på en egen rad med antal tecken i ordet(ex hej(3))
        }
    }
}
