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
    /// Logique d'interaction pour UserControlPanier.xaml
    /// </summary>
    public partial class UserControlPanier : UserControl
    {
        public UserControlPanier()
        {
            InitializeComponent();
            DataContext = new PanierViewModel();
        }
    }
}
