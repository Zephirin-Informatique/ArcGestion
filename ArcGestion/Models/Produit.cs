using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcGestion.Models
{
    public class Produit
    {
        [PrimaryKey, AutoIncrement] 
        public int Id { get; set; } 
        public string Libelle { get; set; }
        public string Categorie { get; set; }
        public int Prix { get; set; }
        public string Details { get; set; }
        public DateTime DateEnreg { get; set; }
        public DateTime DateExp { get; set; }
        public string Image { get; set; }

    }
}
