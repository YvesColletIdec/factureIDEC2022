﻿using prjEFCore.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfFacture.ViewModel
{
    public class FactureDetailViewModel : BaseViewModel
    {

        private int _factureId;

        public int FactureId
        {
            get { return _factureId; }
            set { _factureId = value; }
        }

        private LigneFacture ligneFactureCourante;

        public LigneFacture LigneFactureCourante
        {
            get { return ligneFactureCourante; }
            set {
                ligneFactureCourante = value;
                FirePropertyChanged();
            }
        }

        private Article article;

        public Article ArticleCourant
        {
            get { return article; }
            set { 
                article = value;
                LigneFactureCourante = new LigneFacture();
                LigneFactureCourante.Id = 0;
                LigneFactureCourante.Article = article;
                LigneFactureCourante.Quantite = 1;
                LigneFactureCourante.PrixUntaire = article.Prix;
                FirePropertyChanged();
                FirePropertyChanged("LigneFactureCourante");
            }
        }

   

        private ObservableCollection<Client> _listeClients;

        public ObservableCollection<Client> ListeClients
        {
            get { return _listeClients; }
            set { _listeClients = value; }
        }

        private ObservableCollection<Article> articles;

        public ObservableCollection<Article> ListeArticles
        {
            get { return articles; }
            set { articles = value; }
        }



        private FactureContext _context;

        private Facture _factureCourante;

        public Facture FactureCourante
        {
            get { return _factureCourante; }
            set { 
                _factureCourante = value;
                FirePropertyChanged();
            }
        }
        public FactureDetailViewModel(int factureId)
        {
            this.FactureId = factureId;
            _context = new FactureContext();
            if (factureId == 0)
            {
                FactureCourante = new Facture() { Id = 0, DateFacture = DateTime.Now, NumFacture = "(vide)" };
            }
            else
            {
                //FactureCourante = _context.Factures.Find(factureId);
                FactureCourante = _context.Factures.FirstOrDefault(f => f.Id == factureId);
            }
            
            ListeClients = new ObservableCollection<Client>(_context.Clients);
            ListeArticles = new ObservableCollection<Article>(_context.Articles);
        }
    }
}
