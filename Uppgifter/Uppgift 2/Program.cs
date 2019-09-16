using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //          Låt användaren mata in en mening.
            Console.WriteLine("Please enter a sentence:");
            string userresponse = Console.ReadLine();

            //          Skriv ut varje ord på en egen rad, i storleksordning(längd på ordet)
            //Tanke: behandla strängen som en array av char
            //när vi hittar ett space, bryt raden
            //hmm, detta tar inte hänsyn till storleken...
            //vi behöver få en array av ord!

            string[] words =  userresponse.Split(' ');

            Console.WriteLine("Words består av {0} ord", words.Length);

            foreach (string s in words)
            {
                Console.WriteLine("{0} ({1})",s, s.Length);
            }

//          Skriv ut varje ord på en egen rad, i omvänd ordning(baklänges)
        }
    }
}
