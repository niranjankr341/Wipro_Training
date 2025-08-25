public class Student {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

public class TrainingContext : DbContext {
    public DbSet<Student> Students { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options) {
        options.UseSqlServer("Data Source=.;Initial Catalog=TrainingDB;Integrated Security=True");
    }
}
