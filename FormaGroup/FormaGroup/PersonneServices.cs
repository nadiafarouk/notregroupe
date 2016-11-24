using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormaGroup
{
    class PersonneServices
    {
        private string chaineConnexion;
        public PersonneServices()
        {
            chaineConnexion = ConfigurationManager.ConnectionStrings["Forma"].ConnectionString;
        }

        public Personne PersonneLecture(SqlDataReader reader)
        {
            Personne p = new Personne();
            p.IdPersonne = (int)reader["IdPersonne"];
            p.Nom = (string)reader["Nom"];
            p.Prenom = (string)reader["Prenom"];
            p.Mail = (string)reader["Mail"];
            p.Civilite = (string)reader["Civilite"];
            p.Adresse = (string)reader["Adresse"];
            p.CodePostal = (string)reader["CodePostal"];
            p.Ville = (string)reader["Ville"];
            p.Password = (string)reader["Password"];
            p.Telephone = (string)reader["Telephone"];
            p.Photo = reader["Photo"] == DBNull.Value ? null : (string)reader["Photo"];
            p.EstAdmin = (bool)reader["EstAdmin"];

            return p;
        }

        public Personne GetPersonneByIdMdp(string mail, string pass)
        {
            Personne p = null;
            using (SqlConnection maConnexion = new SqlConnection(chaineConnexion))
            {
                string maRequete = "SELECT * FROM Personne WHERE Mail = @mail AND Password = @pass";
                try
                {
                    maConnexion.Open();
                    using (SqlCommand maCommande = new SqlCommand(maRequete, maConnexion))
                    {
                        maCommande.Parameters.Add(new SqlParameter("@mail", mail));
                        maCommande.Parameters.Add(new SqlParameter("@pass", pass));

                        SqlDataReader maLecture = maCommande.ExecuteReader();
                        if (maLecture.Read())
                        {
                            p = PersonneLecture(maLecture);
                        }
                        maLecture.Close();
                    }
                    maConnexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            return p;
        }
    }
}

