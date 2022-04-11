using System;
using System.Collections.Generic;

#nullable disable

namespace prjEntity2.MesClasses
{
    public partial class Categorie
    {
        public Categorie()
        {
            Articles = new HashSet<Article>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
