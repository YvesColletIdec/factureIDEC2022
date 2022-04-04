using System;
using System.Collections.Generic;

#nullable disable

namespace prjEFCore.Models
{
    public partial class LigneFacture
    {
        public int Id { get; set; }
        public int FactureId { get; set; }
        public int ArticleId { get; set; }
        public int Quantite { get; set; }
        public decimal PrixUntaire { get; set; }

        public virtual Article Article { get; set; }
        public virtual Facture Facture { get; set; }
    }
}
