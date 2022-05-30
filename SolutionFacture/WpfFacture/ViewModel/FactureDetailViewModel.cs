using prjEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfFacture.ViewModel
{
    class FactureDetailViewModel : BaseViewModel
    {
        private Facture _factureCourante;

        public Facture FactureCourante
        {
            get { return _factureCourante; }
            set { 
                _factureCourante = value;
                FirePropertyChanged();
            }
        }

    }
}
