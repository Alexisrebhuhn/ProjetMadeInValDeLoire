using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_ProjVal_TU_Kenan
{
    internal class resultat
    {
        #region property
        //int numeroQuiz;
        private int numeroQuiz;

        public int NumeroQuiz
        {
            get { return numeroQuiz; }
            set { numeroQuiz = value; }
        }

        //String idJoueur;
        private String idJoueur;

        public String IdJoueur
        {
            get { return idJoueur; }
            set { idJoueur = value; }
        }

        //DateTime dateOptention;
        private DateTime dateOptention;

        public DateTime DateOptention
        {
            get { return dateOptention; }
            set { dateOptention = value; }
        }

        //int nbBonneRep;
        private int nbBonneRep;

        public int NbBonneRep
        {
            get { return nbBonneRep; }
            set { nbBonneRep = value; }
        }
        #endregion

        /// <summary>
        /// constrecteur de la classe resultat
        /// </summary>
        /// <param name="wnumeroQuiz"></param>
        /// <param name="wid"></param>
        /// <param name="wdate"></param>
        /// <param name="wnbBonneRep"></param>
        public resultat(int wnumeroQuiz, String wid, DateTime wdate, int wnbBonneRep) 
        { 
            numeroQuiz = wnumeroQuiz;
            idJoueur = wid;
            dateOptention = wdate;
            nbBonneRep = wnbBonneRep;
        }

    }
}
