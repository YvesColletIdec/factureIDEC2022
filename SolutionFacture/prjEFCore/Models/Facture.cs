using System;
using System.Collections.Generic;

#nullable disable

namespace prjEFCore.Models
{
    public partial class Facture
    {
        public Facture()
        {
            LigneFactures = new HashSet<LigneFacture>();
        }

        public int Id { get; set; }
        public DateTime DateFacture { get; set; }
        public int? ClientId { get; set; }
        public string NumFacture { get; set; }

        public virtual Client Client { get; set; }
        public virtual ICollection<LigneFacture> LigneFactures { get; set; }
    }
}
