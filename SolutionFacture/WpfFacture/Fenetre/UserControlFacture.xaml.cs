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
            wfd.Show();
            //Console.WriteLine(idFacture);
            //object Toto = null;
            //Toto = new FactureViewModel();
            //if (Toto is FactureViewModel)
            //{
            //    Console.WriteLine("yeah");
            //}
        }
    }
}
