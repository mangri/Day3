using System;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*decimal number = 100M;
            Console.WriteLine("All decimal places {0}", number);
            //Neveikia Console.WriteLine("All decimal places {0:R}", number);
            double x = 12.55;
            int a;
            a = (int)x;
            Console.WriteLine(a);

            float f = 56.11f;
            Console.WriteLine("ToString " + Convert.ToString(f));

            string vardas = "M";
            Console.WriteLine("String to int " + Convert.ToInt32(vardas));
            */
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
            
















        }
    }
}
