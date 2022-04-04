using System;
using System.Collections.Generic;

#nullable disable

namespace prjEFCore.Models
{
    public partial class Client
    {
        public Client()
        {
            Factures = new HashSet<Facture>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Npa { get; set; }
        public string Localite { get; set; }

        public virtual ICollection<Facture> Factures { get; set; }
    }
}
