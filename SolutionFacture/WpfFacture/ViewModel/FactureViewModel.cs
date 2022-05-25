using prjEFCore.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfFacture.ViewModel
{
    public class FactureViewModel : BaseViewModel
    {
        private ObservableCollection<Facture> _listeFactures;

        public ObservableCollection<Facture> ListeFactures
        {
            get { return _listeFactures; }
            set { 
                _listeFactures = value;
                FirePropertyChanged();
            }
        }

        private Facture _factureCourante;

        public Facture FactureCourante
        {
            get { return _factureCourante; }
            set { 
                _factureCourante = value;
                FirePropertyChanged();
            
            }
        }

        private FactureContext _context;


        public FactureViewModel()
        {
            _context = new FactureContext();
            ListeFactures = new ObservableCollection<Facture>(_context.Factures);
        }
    }
}
