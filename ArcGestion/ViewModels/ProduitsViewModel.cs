using ArcGestion.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcGestion.ViewModels
{
    public class ProduitsViewModel
    {
        private Produit _selectedProduit;

        public ObservableCollection<Produit> ProduitList { get;}
        public Command LoadProduitsCommand { get; }
        public Command AddProduitCommand { get; }
        public Command<Produit> ItemTapped { get; }

        bool show;
        public bool Show
        {
            get => show;
            set
            {
                show = value;
            }
        }


    }
}
