using prjEFCore.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication.Utilities;

namespace WpfFacture
{
    //mon viewmodel pour la gestion de  l'interface graphique
    class ArticleViewModel : BaseViewModel
    {
        private string template = @"C:\Users\Yves\github\factureIDEC2022\SolutionFacture\WpfFacture\template\articles_template.docx";
        public RelayCommand PrintCommand { get; set; }
        private FactureContext _context;

        private ObservableCollection<Article> _listArticles;

        public ObservableCollection<Article> ListArticles
        {
            get { return _listArticles; }
            set { 
                _listArticles = value;
                FirePropertyChanged();
            }
        }

        private Article _articleSelectionne;

        public Article ArticleSelectionne
        {
            get { return _articleSelectionne; }
            set { 
                _articleSelectionne = value;
                FirePropertyChanged();
            }
        }

        private ObservableCollection<Categorie> _listCategorie;

        public ObservableCollection<Categorie> ListCategorie
        {
            get { return _listCategorie; }
            set { 
                _listCategorie = value;
                FirePropertyChanged();
            }
        }

        private RelayCommand _nouveauCommand;

        public RelayCommand NouveauCommand
        {
            get { return _nouveauCommand; }
            set { _nouveauCommand = value; }
        }

        private RelayCommand _sauverCommand;

        public RelayCommand SauverCommand
        {
            get { return _sauverCommand; }
            set { _sauverCommand = value; }
        }



        //constructeur pour récupérer toutes les données
        public ArticleViewModel()
        {
            //récupération des articles
            _context = new FactureContext();
            ListArticles = new ObservableCollection<Article>(_context.Articles);
            ArticleSelectionne = ListArticles.FirstOrDefault();
            ListCategorie = new ObservableCollection<Categorie>(_context.Categories);
            NouveauCommand = new RelayCommand(Nouveau);
            SauverCommand = new RelayCommand(Sauver);
            PrintCommand = new RelayCommand(Imprimer);
        }

        private void Imprimer()
        {
            Print.CreateDocumentArticle(ListArticles.ToList(), template);
        }
        private void Nouveau()
        {
            ArticleSelectionne = new Article() {Nom = "", Designation = "", EstActif = true };
            ListArticles.Add(ArticleSelectionne);
        }

        private void Sauver()
        {
            //ajouter les nouveaux articles
            foreach(Article a in ListArticles)
            {
                if (a.Id == 0)
                {
                    //insert
                    _context.Articles.Add(a);
                }
            }
            //enregistrer les modifications sur les articles existants
            _context.SaveChanges();
        }

        public void FiltrerArticles(string filtre)
        {
            //SELECT * FROM ARTICLES WHERE NOM LIKE '%filtre%'
            ListArticles = new ObservableCollection<Article>(
                _context.Articles.Where(
                    a => a.Nom.Contains(filtre)
                || a.Designation.Contains(filtre)
                ));
        }

    }
}
