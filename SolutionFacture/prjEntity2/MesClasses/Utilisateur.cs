using System;
using System.Collections.Generic;

#nullable disable

namespace prjEntity2.MesClasses
{
    public partial class Utilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string NumEmploye { get; set; }
        public string MotDePasse { get; set; }
        public bool? EstActif { get; set; }
    }
}
