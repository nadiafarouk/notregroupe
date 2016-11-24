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
    class FormationServices
    {
        private string chaineConnexion;
        public FormationServices()
        {
            chaineConnexion = ConfigurationManager.ConnectionStrings["Forma"].ConnectionString;
        }

        public Formation FormationLecture(SqlDataReader reader)
        {
            Formation f = new Formation();
            f.IdFormation = (int)reader["IdFormation"];
            f.Intitule = (string)reader["Intitule"];
            f.Description = (string)reader["Description"];


            return f;
        }

        public Formation CreerFormation(string intitule, string description)
        {
            Formation f = null;
            using (SqlConnection maConnexion = new SqlConnection(chaineConnexion))
            {
                string maRequete = "INSERT INTO Formation(Intitule,Description) VALUES(@Intitule,@Description)";
                try
                {
                    maConnexion.Open();
                    using (SqlCommand maCommande = new SqlCommand(maRequete, maConnexion))
                    {
                        maCommande.Parameters.Add(new SqlParameter("@Intitule", intitule));
                        maCommande.Parameters.Add(new SqlParameter("@Description", description));

                        SqlDataReader maLecture = maCommande.ExecuteReader();
                        if (maLecture.Read())
                        {
                            f = FormationLecture(maLecture);
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
            return f;
        }
        public List<Formation> GetListeFormation()
        {
            List<Formation> formations = new List<Formation>();


            string maRequette = "SELECT*FROM Formation";
            using (SqlConnection maConnection = new SqlConnection(chaineConnexion))
            {

                try
                {
                    maConnection.Open();
                    using (SqlCommand maCommande = new SqlCommand(maRequette, maConnection))
                    {
                        SqlDataReader maLecture = maCommande.ExecuteReader();
                        while (maLecture.Read())
                        {
                            Formation formation = FormationLecture(maLecture);


                            formations.Add(formation);

                        }
                        maLecture.Close();
                    }
                    maConnection.Close();


                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }
            return formations;
        }

        public Formation ModifierFormation(int idFormation, string intitule, string description)
        {
            Formation f = new Formation();
            using (SqlConnection maConnexion = new SqlConnection(chaineConnexion))
            {
                string maRequete = "UPDATE Formation SET Intitule=@Intitule, Description=@Description WHERE IdFormation=@IdFormation";
                try
                {
                    maConnexion.Open();
                    using (SqlCommand maCommande = new SqlCommand(maRequete, maConnexion))
                    {
                        SqlParameter param = new SqlParameter("@IdFormation", System.Data.SqlDbType.Int);

                        //maCommande.Parameters.Add(param);
                        maCommande.Parameters.Add(new SqlParameter("@IdFormation", idFormation));
                        maCommande.Parameters.Add(new SqlParameter("@Intitule", intitule));
                        maCommande.Parameters.Add(new SqlParameter("@Description", description));


                        SqlDataReader maLecture = maCommande.ExecuteReader();
                        if (maLecture.Read())
                        {
                            f = FormationLecture(maLecture);
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
            return f;
        }

    }
}
