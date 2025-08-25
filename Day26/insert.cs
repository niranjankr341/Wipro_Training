using System;
using System.Data.SqlClient;

class Program {
    static void Main() {
        string connStr = "Data Source=.;Initial Catalog=TrainingDB;Integrated Security=True";
        using(SqlConnection con = new SqlConnection(connStr)) {
            con.Open();
            string query = "INSERT INTO Students(Id,Name,Age) VALUES(@id,@name,@age)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", 1);
            cmd.Parameters.AddWithValue("@name", "Niranjan");
            cmd.Parameters.AddWithValue("@age", 22);
            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine(rows + " row(s) inserted");
        }
    }
}
