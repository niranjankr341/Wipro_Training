[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase {
    [HttpGet]
    public IEnumerable<string> Get() {
        return new string[]{"Niranjan","Himanshu"};
    }
}
