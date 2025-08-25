 IActionResult About() {
    var student = new Student{Id=1,Name="Niranjan"};
    return View(student);
}
