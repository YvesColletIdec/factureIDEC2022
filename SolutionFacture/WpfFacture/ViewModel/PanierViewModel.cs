using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfFacture.ViewModel
{
    public class PanierViewModel : BaseViewModel
    {
        private ObservableCollection<string> _listeDeCourses;

        public ObservableCollection<string> ListeDeCourses
        {
            get { return _listeDeCourses; }
            set { 
                _listeDeCourses = value;
                FirePropertyChanged();
            }
        }

        private string _fruit;

        public string Fruit
        {
            get { return _fruit; }
            set { 
                _fruit = value;
                FirePropertyChanged();
            }
        }

        private RelayCommand _ajouterCommand;

        public RelayCommand AjouterCommand
        {
            get { return _ajouterCommand; }
            set { 
                _ajouterCommand = value;
                FirePropertyChanged();
            }
        }

        public PanierViewModel()
        {
            AjouterCommand = new RelayCommand(Ajouter);
            ListeDeCourses = new ObservableCollection<string>();
        }

        public void Ajouter()
        {
            ListeDeCourses.Add(Fruit);
        }
    }
}
