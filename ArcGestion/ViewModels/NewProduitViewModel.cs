using ArcGestion.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcGestion.ViewModels
{
    [QueryProperty(nameof(ProduitId), nameof(ProduitId))]
    public class NewProduitViewModel : BaseViewModel
    {
        private string titre;
        private string libelle;
        private string categorie;
        private decimal prix;
        private string details;
        private DateTime dateEnreg;
        private DateTime dateExp;
        private string boutonTexte;
        private bool imageVisible;
        private bool showSectionImage;
        private ImageSource imageSource;
        public Stream stream { get; set; } = new MemoryStream();

        public ImageSource SourceImage
        {
            get => imageSource;
            set => SetProperty(ref imageSource, value);
        }

        public string BoutonTexte
        {
            get => boutonTexte;
            set => SetProperty(ref boutonTexte, value);
        }

        public string Titre
        {
            get => titre;
            set => SetProperty(ref titre, value);
        }
        
        public string Libelle
        {
            get => libelle;
            set => SetProperty(ref libelle, value);
        }

        public bool ImageVisible
        {
            get => imageVisible;
            set => SetProperty(ref imageVisible, value);
        }

        public bool ShowSectionImage
        {
            get => showSectionImage;
            set => SetProperty(ref showSectionImage, value);
        }

        private int produitId;
        public int ProduitId
        {
            get => produitId;
            set
            {
                produitId = value;
                if (produitId > 0)
                {
                    LoadProduitId(value);
                    Titre = "Modifier un eleve";
                }
                OnPropertyChanged();
            }
        }
        private Produit produit;
        public Produit Produit
        {
            get => produit;
            set
            {
                produit = value;
                OnPropertyChanged();
            }
        }
        private async void LoadProduitId(int value)
        {
            try
            {
                //Produit = await App.MockDataStore.GetItemAsync(ProduitId);
                if (Produit != null)
                {
                    //SelectedExamen = item.Examen;
                    //if (!string.IsNullOrEmpty(item.Serie))
                    //{
                    //    SelectedSerie = item.Serie;
                    //    showSerie = true;
                    //}
                    //SelectedNature = item.NatureCandidat;
                    //Nom = item.Nom;
                    //Prenom = item.Prenom;
                    //SelectedGenre = item.Sexe;
                    //DateNaissance = item.DateNaissance;
                    //LieuNaissance = item.LieuNaissance;
                    //PaysNaissance = item.PaysNaissance;
                    //Image = item.Image;
                    ShowSectionImage = true;
                    ImageVisible = true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
