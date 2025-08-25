var groups = students.GroupBy(s=>s.Age);
foreach(var g in groups) {
    Console.WriteLine($"Age: {g.Key}");
    foreach(var s in g) Console.WriteLine(" " + s.Name);
}
