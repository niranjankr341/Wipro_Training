using System.Data;
using System.Data.SqlClient;

string connStr = "Data Source=.;Initial Catalog=TrainingDB;Integrated Security=True";
SqlConnection con = new SqlConnection(connStr);
SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", con);
DataSet ds = new DataSet();
da.Fill(ds, "Students");

foreach(DataRow row in ds.Tables["Students"].Rows) {
    Console.WriteLine(row["Name"] + " " + row["Age"]);
}
