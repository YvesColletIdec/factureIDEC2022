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
using WpfFacture.utilities;

namespace WpfFacture.Fenetre
{
    /// <summary>
    /// Logique d'interaction pour WindowLogin.xaml
    /// </summary>
    public partial class WindowLogin : Window
    {
        public Utilisateur monUtilisateur = null;
        public WindowLogin()
        {
            InitializeComponent();
        }

        private void BTN_Quitter_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BTN_Connecter_Click(object sender, RoutedEventArgs e)
        {
            FactureContext context = new FactureContext();
            string login = TB_Login.Text;
            string pwd = TB_Password.Password;
            pwd = MotDePasseUtilitaires.ChiffrerMdp(pwd);
            Utilisateur util = context.Utilisateurs.FirstOrDefault(u => u.Nom == login && u.MotDePasse == pwd);
            if (util == null)
            {
                TXT_Erreur.Content = "échec de la connexion";
            } else
            {
                TXT_Erreur.Content = $"Bienvenue {util.Nom}";
                monUtilisateur = util;
                DialogResult = true;
            }
        }
    }
}
