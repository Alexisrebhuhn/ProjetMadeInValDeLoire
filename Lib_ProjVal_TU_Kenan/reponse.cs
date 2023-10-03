using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_ProjVal_TU_Kenan
{
    internal class reponse
    {
        #region property
        //int numeroQuestion;
        private int numeroQuestion;

        public int NumeroQuestion
        {
            get { return numeroQuestion; }
            set { numeroQuestion = value; }
        }

        //int numeroProposition;
        private int numeroProposition;

        public int NumeroProposition
        {
            get { return numeroProposition; }
            set { numeroProposition = value; }
        }
        #endregion
        /// <summary>
        /// constrecteur de la classe reponce
        /// </summary>
        /// <param name="wnumeroQuestion"></param>
        /// <param name="wnumeroProposition"></param>
        public reponse(int wnumeroQuestion, int wnumeroProposition)
        {
            numeroQuestion = wnumeroQuestion;
            numeroProposition = wnumeroProposition;
        }
    }
}
