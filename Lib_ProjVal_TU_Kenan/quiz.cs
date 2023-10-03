using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_ProjVal_TU_Kenan
{
    internal class quiz
    {
        #region property
        //int numero;
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        //String titre;
        private String titre;

        public String Titre
        {
            get { return titre; }
            set { titre = value; }
        }

        //String description;
        private String description;

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        //DateTime dateCréation;
        private DateTime dateCreation;

        public DateTime DateCreation
        {
            get { return dateCreation; }
            set { dateCreation = value; }
        }

        //TimeSpan dureeEstimee;
        private TimeSpan dureeEstimee;

        public TimeSpan DureeEstimee
        {
            get { return dureeEstimee; }
            set { dureeEstimee = value; }
        }

        //int nombreQuestion;
        private int nombreQuestion;

        public int NombreQuestion
        {
            get { return nombreQuestion; }
            set { nombreQuestion = value; }
        }

        //String niveauDifficulte;
        private String niveauDifficulte;

        public String NiveauDifficulte
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
        /// constrecteur de la classe quiz
        /// </summary>
        /// <param name="wnumero"></param>
        /// <param name="wtitre"></param>
        /// <param name="wdescription"></param>
        /// <param name="wdateCreation"></param>
        /// <param name="wdureeEstimee"></param>
        /// <param name="wnombreQuestion"></param>
        /// <param name="wniveauDifficulte"></param>
        /// <param name="wtheme"></param>
        public quiz(int wnumero, string wtitre, string wdescription, DateTime wdateCreation, TimeSpan wdureeEstimee, int wnombreQuestion, string wniveauDifficulte, string wtheme)
        {
            numero = wnumero;
            titre = wtitre;
            description = wdescription;
            dateCreation = wdateCreation;
            dureeEstimee = wdureeEstimee;
            nombreQuestion = wnombreQuestion;
            niveauDifficulte = wniveauDifficulte;
            theme = wtheme;
        }
    }
}
