[HttpPost]
IActionResult Post([FromBody] Student s) {
    return Ok("Student Added: " + s.Name);
}
