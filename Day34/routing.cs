[Route("student/{id}")]
 IActionResult Get(int id) {
    return Content("Student id: " + id);
}
