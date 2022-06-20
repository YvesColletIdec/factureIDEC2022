using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfFacture.ViewModel;

namespace WpfFacture.Fenetre
{
    /// <summary>
    /// Logique d'interaction pour WindowFactureDetail.xaml
    /// </summary>
    public partial class WindowFactureDetail : MetroWindow
    {
        private int _factureId;

        public int FactureId
        {
            get { return _factureId; }
            set { _factureId = value; }
        }

       

        public WindowFactureDetail(int factureId)
        {
            FactureId = factureId;
            FactureDetailViewModel fdvm = new FactureDetailViewModel(factureId);
            DataContext = fdvm;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
