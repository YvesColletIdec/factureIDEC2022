using prjEntity2.MesClasses;
using System;
using System.Collections.Generic;

namespace prjEntity2
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            SqlServerContext baseDeDonnees = new SqlServerContext();
            //select * from client
            List<Client> listeDeClients = new List<Client>(baseDeDonnees.Clients);
            foreach (Client c in listeDeClients)
            {
                Console.WriteLine(c.Nom);
            }
        }
    }
}
