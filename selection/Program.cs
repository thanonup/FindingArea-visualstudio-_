using System;

namespace selection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 is Triangle");
            Console.WriteLine("2 is Rectangle");
            Console.WriteLine("3 is Circle");
            Console.Write("select 1 or 2 or 3 : ");
            int caseSwitch = int.Parse(Console.ReadLine());

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("You Chosse 1");
                    Console.WriteLine(" Triangle Area ");
                    Console.Write("Your B :");
                    double B = double.Parse(Console.ReadLine());
                    Console.Write("Your H :");
                    double H = double.Parse(Console.ReadLine());
                    double sumT = 0.5f * H * B;
                    Console.Write("Your Result : {0}", sumT);
                    break;
                case 2:
                    Console.WriteLine("You Chosse 2");
                    Console.WriteLine(" Rectangle Area ");
                    Console.Write("Your W :");
                    double W = double.Parse(Console.ReadLine());
                    Console.Write("Your L :");
                    double L = double.Parse(Console.ReadLine());
                    
                    double sumR = W * L;
                    Console.Write("Your Result : {0}", sumR);
                    break;
                case 3:
                    Console.WriteLine("You Chosse 3");
                    Console.WriteLine(" Circle Area ");
                    Console.Write("Your R :");
                    double R = float.Parse(Console.ReadLine());
                    double pi = MathF.PI;
                    double sumC = pi * (R * R);
                    Console.Write("Your Result : {0}", sumC);
                    break;
                default:
                    Console.WriteLine("Wrong!"); 
                    break;
            }

        }
    }
}
