using System;
using System.Collections.Generic;

#nullable disable

namespace prjEFCore.Models
{
    public partial class Facture
    {
        public string PrenomNomClient
        {
            get { return this.Client == null ? "-" :  $"{this.Client.Prenom} {this.Client.Nom}"; }

        }

        public string DateFactureFormatee
        {
            get
            {
                return this.DateFacture.ToString("dd.MM.yyyy");
            }
        }

        public int TotalArticles
        {
            get
            {
                int nombreArticles = 0;
                foreach(LigneFacture lf in this.LigneFactures)
                {
                    nombreArticles += lf.Quantite;
                }
                return nombreArticles;
            }
        }

        public string TotalFacture
        {
            get
            {
                decimal prixFacture = 0m;
                foreach (LigneFacture lf in this.LigneFactures)
                {
                    prixFacture += lf.Quantite * lf.PrixUntaire;
                }
                return $"CHF {prixFacture}";
            }
        }


    }
}
