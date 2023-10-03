using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace Lib_ProjVal_TU_Kenan
{
    public class ConnectionBdd
    {
        MySqlConnection laConnection;
      
        public void ConnectionABase()
        {

            try
            {
                laConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["bddString"].ConnectionString);
                laConnection.Open();
                string message = "Connexion ok";
                string caption = "Validation accès Données";
            }
            catch (MySqlException ex)
            {
                string message = "Problème d'accès à vos données.Contacter votre administrateur";
                string caption = "Erreur rencontrée";

            }

        }

        public void deconnexion()
        {
            try
            {
                laConnection.Close();
            }
            catch (MySqlException ex)
            {

            }
        }

        


    }
}
