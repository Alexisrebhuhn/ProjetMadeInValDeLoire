using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_ProjVal_TU_Kenan
{
    public class theme
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
        /// constrecteur de la classe theme
        /// </summary>
        /// <param name="wnuero"></param>
        /// <param name="wlibelle"></param>
        public theme(int wnuero, String wlibelle)
        {
            numero = wnuero;
            libelle = wlibelle;
        }


    }
}
