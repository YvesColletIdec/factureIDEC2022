using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEntity2.MesClasses
{
    public partial class Client
    {
        public string PrenomNom { get { return $"{Prenom} {Nom}"; } }
    }
}
