using System;
using System.Collections.Generic;

#nullable disable

namespace prjEFCore.Models
{
    public partial class LigneFacture
    {

        public decimal TotalLigne
        {
            get { return Quantite * PrixUntaire; }
        }

    }
}
