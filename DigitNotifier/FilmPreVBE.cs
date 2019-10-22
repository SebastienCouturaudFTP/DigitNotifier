using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNotify
{
    class FilmPreVBE
    {
        private const int MaxTitleLength = 26;
        public int TID { get; set; }
        public string TitFilm { get; set; }
        public string Fichier { get; set; }
        public DateTime? DateUpload { get; set; }
        public int Statut { get; set; }
        public Boolean Nouveau { get; set; }

        public string GetShortTitle()
        {
            if (TitFilm.Length > MaxTitleLength)
                return TitFilm.Substring(0, MaxTitleLength) + " ...";
            else
                return TitFilm;
        }
    }
}
