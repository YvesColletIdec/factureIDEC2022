using prjEFCore.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfFacture.ViewModel
{
    public class CategorieViewModel : BaseViewModel
    {
        private FactureContext _context;

        private ObservableCollection<Categorie> _listeCategories;

        public ObservableCollection<Categorie> ListeCategories
        {
            get { return _listeCategories; }
            set { 
                _listeCategories = value;
                FirePropertyChanged();
            }
        }

        private Categorie _categorieSelectionnee;

        public Categorie CategorieSelectionnee
        {
            get { return _categorieSelectionnee; }
            set { 
                _categorieSelectionnee = value;
                FirePropertyChanged();
            }
        }

        public CategorieViewModel()
        {
            _context = new FactureContext();
            ListeCategories = new ObservableCollection<Categorie>(_context.Categories.OrderBy(c => c.Nom));
            CategorieSelectionnee = ListeCategories.First();
        }
    }
}
