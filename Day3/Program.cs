using System;
using Microsoft.VisualBasic;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //-?AR GALIMA NEAPVALINTI
                                    /*
                                      float number = 3.197f;
                                      Console.WriteLine("Decimal places {0:0.00}", number);
                                    */                           
        //-?KAIP GAUTI CHAR KODUS
                                    /*
                                      string charas = "M";
                                      Console.WriteLine("String to int " + Convert.ToInt32(charas));
                                    */
                                      
        //+03_01 SEQUENCE CHANGE
                                    /*
                                      Console.WriteLine("Uzduotis SEKOS APGREZIMAS");
                                      char a = Convert.ToChar(Console.ReadLine());
                                      char b = Convert.ToChar(Console.ReadLine());
                                      char c = Convert.ToChar(Console.ReadLine());
                                      Console.WriteLine($"{c} {b} {a}");
                                    */  
        //+03_02 CONV M/S TO KM/H
                                    /*
                                      Console.WriteLine("Uzduotis 2");
                                      Console.WriteLine("Ivesk atstuma metrais");
                                      double atstumas = Convert.ToDouble(Console.ReadLine());
                                      Console.WriteLine("Laika sekundemis");
                                      double laikas = Convert.ToDouble(Console.ReadLine());
                                      Console.WriteLine("Tavo greitis yra " + (atstumas/laikas)*3.6 + " km/h");
                                    */
        //+03_03 SPHERE VOL AND S
                                    /*
                                      Console.WriteLine("Uzduotis 3");
                                      double pi = Math.PI;
                                      Console.WriteLine("Koks rutulio diametras?");
                                      double d = Convert.ToDouble(Console.ReadLine());
                                      Console.WriteLine("Rutulio plotas yra " + 4*pi*(d/2)*(d/2) + " kvadratiniu vienetu");
                                      Console.WriteLine("Rutulio turis yra " + Math.Round((4/3) * pi * Math.Pow((d / 2),3),2) + " kubiniu vienetu");
                                    */
        //+03_04 CHECK EVEN NUMB.
                                    /*
                                      Console.WriteLine("Uzduotis 4");
                                      Console.WriteLine("Ivesk pirma skaiciu");
                                      int Nr0 = Convert.ToInt32(Console.ReadLine());
                                      Console.WriteLine("Ivesk antra skaiciu");
                                      int Nr1 = Convert.ToInt32(Console.ReadLine());
                                      Console.WriteLine("Manai abu skaiciai lyginiai? " + ((Nr0%2==0)&&(Nr1%2==0)));
                                    */
        //+03_05 DRAWING WITH SYM
                                    /*
                                      Console.WriteLine("Uzduotis Trikampis");
                                      Console.WriteLine("Ivesk bet koki simboli");
                                      string Tr = Console.ReadLine();
                                      Console.WriteLine(Tr);
                                      Console.WriteLine(Tr+Tr);
                                      Console.WriteLine(Tr+Tr+Tr);
                                    */
        //+03_06 LOGIN TO ACCOUNT
                                    /*  
                                      int countBadName = 1;
                                      int countBadPass = 1;
                                      string userName = "admin";
                                      string userPass = "admin";
                          
                                      string inputName = "";
                                      string inputPass = "";
                                      while (countBadName<=3 && inputName!=userName)
                                      {
                                          Console.WriteLine("Please enter your username, trial " + countBadName);
                                          inputName = Console.ReadLine();
                                          if(inputName == userName)
                                          {
                                              Console.WriteLine("Username " + userName + " found in the system");
                                              while (countBadPass <= 3 && inputPass != userPass)
                                              {
                                                  Console.WriteLine("Please enter your password for " + userName + " , trial " + countBadPass);
                                                  inputPass = Console.ReadLine();
                                                  if(inputPass == userPass)
                                                  {
                                                      Console.WriteLine("Congratulations, go ahead with your account");
                                                      Environment.Exit(0);
                                                  }
                                                  else
                                                  {
                                                      countBadPass++;
                                                  }
                                              }
                                              Console.WriteLine("Too many attempts, your account is temporarily  blocked");
                                              Environment.Exit(0);
                                          }
                                          else
                                          {
                                              countBadName++;
                                          }
                                      }
                                      Console.WriteLine("Sorry, the user  was not found");
                                    */
        //+03_07 TYPE OF BAND
                                    /*
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
                                    */
        //+03_08 WORKING HOURS
                                    /*
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
                                    */
        //+03_09 EXAM RESULTS
                                    /*
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


/**KEY NOTES START**/     
                            /*
                              double x = 12.55;
                              int a;
                              a = (int)x;
                              Console.WriteLine(a);
                              
                              float f = 56.11f;
                              Console.WriteLine("ToString " + Convert.ToString(f));

                              int default_=0;
                              string input = Console.ReadLine()
                              bool convert = int.TryParse(input, out default_);
                            */
/**KEY NOTES END**/

}
}
}
