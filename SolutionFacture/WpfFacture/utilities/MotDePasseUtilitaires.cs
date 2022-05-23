using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfFacture.utilities
{
    public class MotDePasseUtilitaires
    {
        public static string ChiffrerMdp(string mdp)
        {
            char[] charArray = mdp.ToCharArray();
            Array.Reverse(charArray);
            string mdp2 = new string(charArray);
            mdp2 += "xxx";
            return mdp2;
        }
    }
}
