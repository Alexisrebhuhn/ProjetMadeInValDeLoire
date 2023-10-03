using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Lib_ProjVal_TU_Kenan
{
    internal class joueur
    {
        #region property
        //int id;
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

        //String prenom;
        private String prenom;

        public String Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        //DateTime dateDeNaissance;
        private DateTime dateDeNaissance;

        public DateTime dateNaissance
        {
            get { return dateDeNaissance; }
            set { dateDeNaissance = value; }
        }

        //String mail;
        private String mail;

        public String Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        //String login;
        private String login;

        public String Login
        {
            get { return login; }
            set { login = value; }
        }

        //String motPasse;
        private String motPasse;

        public String MotPasse
        {
            get { return motPasse; }
            set { motPasse = value; }
        }

        //int section;
        private int section;

        public int Section
        {
            get { return section; }
            set { section = value; }
        }
        #endregion

        /// <summary>
        /// Constructeur de la classe joueur
        /// </summary>
        /// <param name="wid"></param>
        /// <param name="wnom"></param>
        /// <param name="wprenom"></param>
        /// <param name="wdate"></param>
        /// <param name="wmail"></param>
        /// <param name="wlogin"></param>
        /// <param name="wmotPasse"></param>
        /// <param name="wsection"></param>
        public joueur(int wid, String wnom, String wprenom, DateTime wdate, String wmail, String wlogin, String wmotPasse, int  wsection)
        {
            id = wid;
            nom = wnom;
            prenom = wprenom;
            dateDeNaissance = wdate;
            mail = wmail;
            login = wlogin;
            motPasse = wmotPasse;
            section = wsection;
        }
    }
}
