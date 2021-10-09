using System;

namespace NombrePremier
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nb, Test = 0;

            Console.WriteLine("Veuillez entrer un nombre entier : ");
            Nb = int.Parse(Console.ReadLine());

            if (Nb <= 3)
                Test = 1;
            else
            {
                int Sqrt_Nb = (int)Math.Sqrt(Nb);
                for (int i = 2; i <= Sqrt_Nb; i++)
                {
                    if (Nb % i == 0)
                    {
                        Test = 0;
                        break;
                    }
                    else
                        Test = 1;
                }
            }
            if (Test != 0)
            {
                Console.WriteLine(Nb + " est premier");
            }
            else
            {
                Console.WriteLine(Nb +" n'est pas premier");
            }
        }
    }
}