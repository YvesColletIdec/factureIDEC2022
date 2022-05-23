using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string mdp = "salut";
            Console.WriteLine(Program.ChiffrerMdp(mdp));
            Console.ReadLine();
        }

        public static string ChiffrerMdp(string mdp)
        {
            char[] charArray = mdp.ToCharArray();
            Array.Reverse(charArray);
            string mdp2 = new string(charArray);
            mdp2 += "xxx";
            return mdp2;
        }

        public void CalculeLaSommeDeDeuxNombres(int nb1, int nb2)
        {
            int somme = nb1 + nb2;
        }

        //public string DechiffrerMdp(string mdp)
        //{
        //    string mdp = 
        //}
    }
}
