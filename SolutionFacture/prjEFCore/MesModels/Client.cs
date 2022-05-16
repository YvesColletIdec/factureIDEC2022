using System;
using System.Collections.Generic;

#nullable disable

namespace prjEFCore.Models
{
    public partial class Client
    {
        public string PrenomNom { get { return $"{Prenom} {Nom}"; } }
    }
}
