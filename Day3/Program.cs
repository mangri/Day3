using System;
using Microsoft.VisualBasic;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = Math.PI/3.14;
          
            Console.WriteLine("Decimal places {0:0.000000}", number);
            
            
            /*double x = 12.55;
            
            int a;
            a = (int)x;
            Console.WriteLine(a);

            float f = 56.11f;
            Console.WriteLine("ToString " + Convert.ToString(f));

            string vardas = "M";
            Console.WriteLine("String to int " + Convert.ToInt32(vardas));
            
            Console.WriteLine("Uzduotis 1");
            char a = Convert.ToChar(Console.ReadLine());
            char b = Convert.ToChar(Console.ReadLine());
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"{c} {b} {a}");

            Console.WriteLine("Uzduotis 2");
            Console.WriteLine("Ivesk atstuma metrais");
            double atstumas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Laika sekundemis");
            double laikas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tavo greitis yra " + (atstumas/laikas)*3.6 + " km/h");

            Console.WriteLine("Uzduotis 3");
            double pi = Math.PI;
            Console.WriteLine("Koks rutulio diametras?");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Rutulio plotas yra " + 4*pi*(d/2)*(d/2) + " kvadratiniu vienetu");
            Console.WriteLine("Rutulio turis yra " + (4/3) * pi * Math.Pow((d / 2),3) + " kubiniu vienetu");

            Console.WriteLine("Uzduotis 4");
            Console.WriteLine("Ivesk pirma skaiciu");
            int Nr0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ivesk antra skaiciu");
            int Nr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Manai abu skaiciai lyginiai? " + ((Nr0%2==0)&&(Nr1%2==0)));

            Console.WriteLine("Uzduotis Trikampis");
            Console.WriteLine("Ivesk bet koki simboli");
            string Tr = Console.ReadLine();
            Console.WriteLine(Tr);
            Console.WriteLine(Tr+Tr);
            Console.WriteLine(Tr+Tr+Tr);

            //int default_=0;
            //string input = Console.ReadLine()
            //bool convert = int.TryParse(input, out default_);


            Console.WriteLine("Uzduotis Login");
            string userName = "admin";
            string userPass = "admin";
            Console.WriteLine("Please enter your username");
            
            Console.WriteLine("Please enter number of members");
            string membersInput = Console.ReadLine();
            int countReal;
            bool convertTrue = int.TryParse(membersInput, out countReal);
            if (convertTrue == false)
            { Console.WriteLine("blogai");
            Environment.Exit(0);   }
            else if (countReal == 1)
                { Console.WriteLine("solo"); }
            else { Console.WriteLine("bye bye"); }
            
            Console.WriteLine("Enter please your C sharp studying hours");
            int goodToGo;
            string theInput = Console.ReadLine();
            bool convertHours = int.TryParse(theInput, out goodToGo);
            if (convertHours==false)
            {
                Console.WriteLine("Did you use alcohol today? Incorrect input!");
                Environment.Exit(0);
            }
            else if (goodToGo==160)
            {
                Console.WriteLine("Good, a full period achieved");
            }
            else if (goodToGo < 160)
            {
                Console.WriteLine("Paycut, go back to work, " + (160-goodToGo) + " hours missing");
            }
            else if (goodToGo > 160)
            {
                Console.WriteLine("You can rest, " + (goodToGo - 160) + " hours on top");
            }
           
            Console.WriteLine("What's your mark?");
            int correctMark;
            string theInput = Console.ReadLine();
            bool maybe = int.TryParse(theInput, out correctMark);
            if (maybe == true)
            {
                switch (correctMark)
                {
                    case <= 4 and >=0:
                        Console.WriteLine("Nepatenkinamai");
                        break;
                    case 5:
                        Console.WriteLine("Silpnai");
                        break;
                    case 6:
                        Console.WriteLine("Patenkinamai");
                        break;
                    case >7 and <=10:
                        Console.WriteLine("Islaikei");
                        break;
                    case >10 :
                        Console.WriteLine("Meluoji");
                        break;
                }
            }
            else if (maybe == false)
            {
                Console.WriteLine("Bloga klaviatura, arba blogai ivedei");
            }
            */

















        }
    }
}
