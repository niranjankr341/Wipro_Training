[Authorize]
[HttpGet("secure")]
string GetSecureData() {
    return "This is secured data.";
}
