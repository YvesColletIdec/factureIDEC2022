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
using WpfFacture.Fenetre;

namespace WpfFacture
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WindowArticle _fenetreArticle;
        WindowCategorie _fenetreCategorie;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menuGestionDesArticles_Click(object sender, RoutedEventArgs e)
        {
            monStackPanel.Children.Clear();
            if (_fenetreArticle == null)
                _fenetreArticle = new WindowArticle();
            monStackPanel.Children.Add(_fenetreArticle);
        }

        private void menuGestionDesCategories_Click(object sender, RoutedEventArgs e)
        {
            monStackPanel.Children.Clear();
            if (_fenetreCategorie == null)
                _fenetreCategorie = new WindowCategorie();
            monStackPanel.Children.Add(_fenetreCategorie);
        }
    }
}
