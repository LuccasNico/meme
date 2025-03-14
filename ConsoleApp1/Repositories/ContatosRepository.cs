using ConsoleApp1.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repository
{
    public class ContatosRepository
    {
        public readonly string connectionString = "Data Source=.;Initial Catalog=hhhggh;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public List<Contatos> GetContatos()
        {
            var contatos = new List<Contatos>();
            try{
                using (SqlConnection connection = new SqlConnection(connectionString)) { 
                    connection.Open();
                    string sql = "SELECT * FROM contatos ORDER BY id DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection)) {
                        using (SqlDataReader reader = command.ExecuteReader())
                            while (reader.Read()) {

                                Contatos contato = new Contatos();
                                contato.Id = reader.GetInt32(0);

                            }
                    } 
                }
            }
            catch (Exception ex){
                const string message = ("Erro ao conectar ao BD. ");
                Console.WriteLine(message + ex);
            }

            return contatos;
        }
    }
}
