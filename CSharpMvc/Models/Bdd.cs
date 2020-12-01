using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CSharpMvc.Models
{
    public class Bdd
    {
        private MySqlConnection connection;

        public Bdd()
        {
            InitConnection();
        }

        private void InitConnection()
        {
            string connectionString = "server=localhost;userid=root;password=;database=mli";
            connection = new MySqlConnection(connectionString);
        }

        public void AddContact(Contact contact)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO contact (id, name, tel) VALUES (@id, @name, @tel)";

            cmd.Parameters.AddWithValue("@id", contact.Id);
            cmd.Parameters.AddWithValue("@name", contact.Name);
            cmd.Parameters.AddWithValue("@tel", contact.Tel);

            cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
