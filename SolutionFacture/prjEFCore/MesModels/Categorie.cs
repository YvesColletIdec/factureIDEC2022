using System;
using System.Collections.Generic;

#nullable disable

namespace prjEFCore.Models
{
    public partial class Categorie
    {
        public bool EstCeQueLImageExiste { 
            get {
                return string.IsNullOrEmpty(this.ImageCat) ? false : true;
               } 
        }

        public string MaVraieUrl { get {
                return EstCeQueLImageExiste ? this.ImageCat : @"C:\Users/Yves\github\factureIDEC2022\images\erreur.jpg";
                    }
        }
    }
}
