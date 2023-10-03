using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_ProjVal_TU_Kenan
{
    internal class questionsQuiz
    {
        #region property
        //int numeroQuiz;
        private int numeroQuiz;

        public int NumeroQuiz
        {
            get { return numeroQuiz; }
            set { numeroQuiz = value; }
        }

        //int numeroQuestion;
        private int numeroQuestion;

        public int NumeroQuestion
        {
            get { return numeroQuestion; }
            set { numeroQuestion = value; }
        }
        #endregion


        /// <summary>
        /// constrecteur de la classe questionQuiz
        /// </summary>
        /// <param name="wnumeroQuiz"></param>
        /// <param name="wnumeroQuestion"></param>
        public questionsQuiz(int wnumeroQuiz, int wnumeroQuestion)
        {
            numeroQuiz = wnumeroQuiz;
            numeroQuestion = wnumeroQuestion;
        }
    }
}
