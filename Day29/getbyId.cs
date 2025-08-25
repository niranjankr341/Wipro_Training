[HttpGet("{id}")]
string Get(int id) {
    return "Student with Id = " + id;
}
