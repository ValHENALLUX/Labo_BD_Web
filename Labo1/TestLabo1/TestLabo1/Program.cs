using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TestLabo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Création de connexion
            SqlConnection DBConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=bidon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            //Ouvrir la connexion
            DBConnection.Open();

            //Insertion ds DB
            //SqlCommand insertion = new SqlCommand("INSERT INTO Student (BirthDate, FullName)", DBConnection);

            //Création de la requête
            SqlCommand request = new SqlCommand("select * from Student ", DBConnection);

            //Éxécution de la commande
            SqlDataReader reader = request.ExecuteReader();
            

            while (reader.Read())
            {
                Console.Write("{0} - {2} ", reader[0], reader[1], reader[2]);
            }

            reader.Close();
            DBConnection.Close();
            System.Console.ReadKey();
        }
    }
}
