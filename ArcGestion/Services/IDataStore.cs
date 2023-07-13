using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcGestion.Services
{
    public interface IDataStore<T>
    {
        //Cette fonction permettra d'ajouter ou mèttre à jour un objet de la base de données
        Task<int> AddOrUpdateItemAsync(T produit);
        //Cette fonction permettra de supprimer un objet de la base de données
        Task<int> DeleteItemAsync(T produit);
        //Cette fonction permettra d'afficher un objet de la base de données
        Task<T> GetItemAsync(int id);
        //Cette fonction permettra de lister les objets de la base de données
        Task<IEnumerable<T>> GetItemsAsync();
    }
}
