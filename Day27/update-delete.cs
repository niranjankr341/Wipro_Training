using(var db = new TrainingContext()) {
    var st = db.Students.First(s=>s.Id==1);
    st.Age = 23;
    db.SaveChanges();
    Console.WriteLine("Updated Age");

    db.Students.Remove(st);
    db.SaveChanges();
    Console.WriteLine("Deleted Student");
}
