using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_ProjVal_TU_Kenan
{
    internal class question
    {
        #region property
        //int numero;
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        //String libelle;
        private String libelle;

        public String Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        //int niveauDifficulte;
        private int niveauDifficulte;

        public int NiveauDifficulte
        {
            get { return niveauDifficulte; }
            set { niveauDifficulte = value; }
        }

        //String theme;
        private String theme;

        public String Theme
        {
            get { return theme; }
            set { theme = value; }
        }
        #endregion
        /// <summary>
        /// constrecteur de la classe question
        /// </summary>
        /// <param name="wnumero"></param>
        /// <param name="wlibelle"></param>
        /// <param name="wniveauDifficulte"></param>
        /// <param name="wtheme"></param>
        public question(int wnumero, String wlibelle, int wniveauDifficulte, String wtheme)
        {
            numero = wnumero;
            libelle = wlibelle;
            niveauDifficulte = wniveauDifficulte;
            theme = wtheme;
        }
    }
}
