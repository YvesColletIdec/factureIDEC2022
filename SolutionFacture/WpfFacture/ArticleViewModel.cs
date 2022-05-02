using prjEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfFacture
{
    //mon viewmodel pour la gestion de  l'interface graphique
    class ArticleViewModel
    {
        private List<Article> _listArticles;

        public List<Article> ListArticles
        {
            get { return _listArticles; }
            set { _listArticles = value; }
        }

        private Article _articleSelectionne;

        public Article ArticleSelectionne
        {
            get { return _articleSelectionne; }
            set { 
                _articleSelectionne = value;
                Console.WriteLine(_articleSelectionne.Designation);
            }
        }

        private List<Categorie> _listCategorie;

        public List<Categorie> ListCategorie
        {
            get { return _listCategorie; }
            set { _listCategorie = value; }
        }



        //constructeur pour récupérer toutes les données
        public ArticleViewModel()
        {
            //récupération des articles
            FactureContext context = new FactureContext();
            ListArticles = context.Articles.ToList();
            ListCategorie = context.Categories.ToList();
        }

    }
}
