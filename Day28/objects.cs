List<Student> students = new() {
    new Student{Id=1,Name="A",Age=20},
    new Student{Id=2,Name="B",Age=22}
};

var adults = students.Where(s=>s.Age>=21).ToList();
adults.ForEach(s=>Console.WriteLine(s.Name));
