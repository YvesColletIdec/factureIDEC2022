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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfFacture.ViewModel;

namespace WpfFacture.Fenetre
{
    /// <summary>
    /// Logique d'interaction pour UserControlFacture.xaml
    /// </summary>
    public partial class UserControlFacture : UserControl
    {
        public UserControlFacture()
        {
            DataContext = new FactureViewModel();
            InitializeComponent();
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //récupération de l'id de la facture
            int idFacture = ((FactureViewModel)DataContext).FactureCourante.Id;
            WindowFactureDetail wfd = new WindowFactureDetail(idFacture);
            wfd.ShowDialog();
            if (wfd.DialogResult.HasValue && wfd.DialogResult.Value)
            {
                DataContext = new FactureViewModel();
            }
            //Console.WriteLine(idFacture);
            //object Toto = null;
            //Toto = new FactureViewModel();
            //if (Toto is FactureViewModel)
            //{
            //    Console.WriteLine("yeah");
            //}
        }

        private void BTN_NEW_Click(object sender, RoutedEventArgs e)
        {
            int idFacture = 0;
            WindowFactureDetail wfd = new WindowFactureDetail(idFacture);
            wfd.ShowDialog();
            if (wfd.DialogResult.HasValue && wfd.DialogResult.Value)
            {
                DataContext = new FactureViewModel();
            }
        }
    }
}
