using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_ProjVal_TU_Kenan
{
    #region property
    internal class niveauDificulte
    {
        //String id;
        private String id;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        //String libelle;
        private String libelle;

        public String Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }
        #endregion

        /// <summary>
        /// constrecteur de la classe niveauDifficulté
        /// </summary>
        /// <param name="wid"></param>
        /// <param name="wlibelle"></param>
        public niveauDificulte(String wid, String wlibelle) 
        {
            id = wid;
            libelle = wlibelle;
        }
    }
}
