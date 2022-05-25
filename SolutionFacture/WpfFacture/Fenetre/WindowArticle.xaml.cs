using prjEFCore.Models;
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

namespace WpfFacture
{
    /// <summary>
    /// Logique d'interaction pour WindowArticle.xaml
    /// </summary>
    public partial class WindowArticle : UserControl
    {
        private Utilisateur _uti;
        public WindowArticle(Utilisateur uti)
        {
            _uti = uti;
            InitializeComponent();
            if (uti.Role == ERole.user.ToString())
            {
                btn_nouveau.IsEnabled = false;
            }
            //instaciation d'un viewmodel pour faire la relation entre les composants graphiques
            //et les propriétés du viewmodel
            DataContext = new ArticleViewModel();
        }

        private void TB_Recherche_KeyUp(object sender, KeyEventArgs e)
        {
            string filtre = TB_Recherche.Text;
            ((ArticleViewModel)DataContext).FiltrerArticles(filtre);
        }
    }
}
