string connStr = "Data Source=.;Initial Catalog=TrainingDB;Integrated Security=True";
using(SqlConnection con = new SqlConnection(connStr)) {
    con.Open();
    SqlCommand cmd = new SqlCommand("SELECT * FROM Students", con);
    SqlDataReader reader = cmd.ExecuteReader();
    while(reader.Read()) {
        Console.WriteLine($"{reader["Id"]} - {reader["Name"]} - {reader["Age"]}");
    }
}
