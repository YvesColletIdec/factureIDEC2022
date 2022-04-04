using System;
using System.Collections.Generic;

#nullable disable

namespace prjEFCore.Models
{
    public partial class Utilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string NumEmploye { get; set; }
        public string MotDePasse { get; set; }
        public string Toto { get; set; }
    }
}
