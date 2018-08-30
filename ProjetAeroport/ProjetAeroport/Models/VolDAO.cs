using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjetAeroport.Models
{
    public class VolDAO
    {

        public static List<Vol> FetchAll()
        {
            string query = "Select * from Vol";
          
            List<Vol> listeVol = new List<Vol>();

            SqlConnection connection = Database.GetConnection();
            
                
                using (var command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                    listeVol.Add(new Vol(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),
                           reader.GetDateTime(7), reader.GetString(8)));
                }
                }
            

            return listeVol;

        }//Fin FetchAll

        public static List<Vol> FetchByDate(DateTime date)
        {
            string query = "Select * from Vol where DATE = '@DATE'";
            List<Vol> listeVol = new List<Vol>();

            SqlConnection connection = Database.GetConnection();

            using (var command = new SqlCommand(query, connection))
            {
                SqlParameter param = new SqlParameter();//Requete Parametrer
                param.ParameterName = "@DATE";
                param.Value = date;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {


                        //monVol.ID = reader.GetString(0);
                        //monVol.Destination = reader.GetString(1);
                        //monVol.Etat = reader.GetString(2);
                        //monVol.Logo = reader.GetString(3);
                        //monVol.Prevu = reader.GetString(4);
                        //monVol.Revise = reader.GetString(5);
                        //monVol.Porte = reader.GetString(6);
                        //monVol.Date = reader.GetDateTime(7);
                        //monVol.TypeVol = reader.GetString(8);

                        listeVol.Add(new Vol(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),
                            reader.GetDateTime(7), reader.GetString(8)));

                    }
                }
            }

            return listeVol;

        }//Fin FetchByDate

        public static List<Vol> FetchByType(string type,string jour)
        {
            string query = "select * from Vol where TYPEVOL = @TYPE and DATE = @JOUR";


            SqlParameter param = new SqlParameter();//Requete Parametrer
            param.ParameterName = "@TYPE";
            param.Value = type;
            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@JOUR";
            param2.Value = jour;


            List<Vol> listeVol = new List<Vol>();
            SqlConnection connection = Database.GetConnection();


            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.Add(param);
                command.Parameters.Add(param2);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listeVol.Add(new Vol(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),
                           reader.GetDateTime(7), reader.GetString(8)));
                    }
                }


                return listeVol;



            }//Fin FetchAll
        }
    }
}