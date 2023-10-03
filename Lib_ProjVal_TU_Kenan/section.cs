using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_ProjVal_TU_Kenan
{
    
    internal class section
    {
        #region property

        // String id;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        //String nom;
        private String nom;

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        //DateTime annee;
        private DateTime annee;

        public DateTime Annee
        {
            get { return annee; }
            set { annee = value; }
        }

        //String specialite;
        private String specialite;

        public String Specialite
        {
            get { return specialite; }
            set { specialite = value; }
        }
        #endregion

        /// <summary>
        /// Constructeur de la classe section
        /// </summary>
        /// <param name="wid"></param>
        /// <param name="wnom"></param>
        /// <param name="wannee"></param>
        /// <param name="wspecialite"></param>
        public section (int wid, String wnom, DateTime wannee, String wspecialite)
        {
            id = wid;
            nom = wnom;
            annee = wannee;
            specialite = wspecialite;
        }
    }
}
