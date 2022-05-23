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
        Utilisateur monUtilisateur;
        public MainWindow()
        {
            WindowLogin wl = new WindowLogin();
            //cacher ou masquer la fenetre actuelle
            //this.Hide();
            //afficher la fenetre de login
            if (wl.ShowDialog().Value)
            {
                //l'utilisateur est connecté
                monUtilisateur = wl.monUtilisateur;
                this.Show();
                InitializeComponent();
                //déterminer si on affiche admin ou non
                if (monUtilisateur.Role == ERole.administrator.ToString())
                {
                    menuAdmin.Visibility = Visibility.Visible;
                } else
                {
                    menuAdmin.Visibility = Visibility.Hidden;
                }
                wl.Hide();
                
            } else
            {
                //l'utilisateur n'est pas connecté
                Application.Current.Shutdown();
            }
            
        }

        private void menuGestionDesArticles_Click(object sender, RoutedEventArgs e)
        {
            monStackPanel.Children.Clear();
            if (_fenetreArticle == null)
                _fenetreArticle = new WindowArticle(monUtilisateur);
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
