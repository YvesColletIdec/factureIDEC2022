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
        UserControlPanier _ucPanier;
        UserControlFacture _ucFacture;
        Utilisateur monUtilisateur;
        public MainWindow()
        {
#if DEBUG
            //MODE DEBUG
            InitializeComponent();
            this.Title = "Gestion des factures (DEV)";
            FactureContext context = new FactureContext();
            monUtilisateur = context.Utilisateurs.FirstOrDefault(u => u.Nom == Utilisateur.ADMIN_NOM);
#else
            //MODE RELEASE
            this.Show();
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
                this.Title = "Gestion des factures (PRD)";
                //déterminer si on affiche admin ou non
                if (monUtilisateur.Role == ERole.administrator.ToString())
                {
                    menuPanier.Visibility = Visibility.Visible;
                }
                else
                {
                    menuPanier.Visibility = Visibility.Hidden;
                }
                wl.Hide();

            }
            else
            {
                //l'utilisateur n'est pas connecté
                Application.Current.Shutdown();
            }
#endif
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

        private void menuPanier_Click(object sender, RoutedEventArgs e)
        {
            monStackPanel.Children.Clear();
            if (_ucPanier == null)
                _ucPanier = new UserControlPanier();
            monStackPanel.Children.Add(_ucPanier);
        }

        private void menuFacture_Click(object sender, RoutedEventArgs e)
        {
            monStackPanel.Children.Clear();
            if (_ucFacture == null)
                _ucFacture = new UserControlFacture();
            monStackPanel.Children.Add(_ucFacture);
        }
    }
}
