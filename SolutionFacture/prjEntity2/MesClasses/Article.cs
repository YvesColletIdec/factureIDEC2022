using System;
using System.Collections.Generic;

#nullable disable

namespace prjEntity2.MesClasses
{
    public partial class Article
    {
        public Article()
        {
            LigneFactures = new HashSet<LigneFacture>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Designation { get; set; }
        public decimal Prix { get; set; }
        public string Commentaire { get; set; }
        public int? CategorieId { get; set; }

        public virtual Categorie Categorie { get; set; }
        public virtual ICollection<LigneFacture> LigneFactures { get; set; }
    }
}
