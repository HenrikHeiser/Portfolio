using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeshamHatHunger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schreibe hier dein Wort: ");
            string s1 = Console.ReadLine();
            Console.WriteLine(s1);
            string reversed = "";
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                reversed += s1[i];
            }
            PalindromTest(s1, reversed);
            Console.ReadKey();

            Console.WriteLine("Gib mal deine Quersumme ein: ");
            string querSumm = Console.ReadLine();
            QuersummeTest(querSumm);
        }
        static void PalindromTest(string s1, string reversed)
        {
            if (s1 == reversed)
            {
                Console.WriteLine("Palindrom hihi");
            }
            else
            {
                Console.WriteLine("Kein Palindrom :(");
            }
            Console.ReadLine();
        }
        static void QuersummeTest(string querSumm)
        {
            int Wort = 0;
            for (int i = 0; i < querSumm.Length; i++)
            {
                string Buchstabe = Convert.ToString(querSumm[i]);
                int Buchstabe1 = Convert.ToInt32(Buchstabe);
                Wort = Wort + Buchstabe1;
            }
            Console.WriteLine(Wort);
            Console.ReadKey();

        }
    }
}
