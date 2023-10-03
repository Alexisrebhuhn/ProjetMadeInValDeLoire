using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_ProjVal_TU_Kenan
{
    internal class proposition
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
        #endregion

        /// <summary>
        /// constrecteur de la classe proposition
        /// </summary>
        /// <param name="wnumero"></param>
        /// <param name="wlibelle"></param>
        public proposition(int wnumero, String wlibelle)
        {
            numero = wnumero;
            libelle = wlibelle;
        }
    }
   
}
