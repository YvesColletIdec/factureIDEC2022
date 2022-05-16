using MahApps.Metro.Controls;
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
    /// Logique d'interaction pour WindowClient.xaml
    /// </summary>
    public partial class WindowClient : MetroWindow
    {
        public WindowClient()
        {
            InitializeComponent();
            Chargement();
        }

        private void Chargement()
        {
            //récupération des clients
            FactureContext context = new FactureContext();
            List<Client> listClients = context.Clients.ToList();

            //affichage des clients dans la datagrid par ordre alphabétique du prénom
            //select * from client c order by c.prenom asc
            //DataGridClient.ItemsSource = listClients.OrderBy(c => c.Prenom);
            //select * from client c where c.prenom = 'Yves'
            DataGridClient.ItemsSource = listClients.Where(c => c.Prenom == "Yves");
        }
    }
}
