using System;
using System.Collections.Generic;

#nullable disable

namespace prjEFCore.Models
{
    public partial class Article
    {
        //public Categorie Cat { get { return Categorie; } set { Categorie = value; } }
        public string CustomizeArticle
        {
            get { return $"{Nom} ({Prix})"; }
        }
    }
}
