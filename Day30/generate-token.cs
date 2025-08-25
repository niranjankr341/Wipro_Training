var tokenHandler = new JwtSecurityTokenHandler();
var key = Encoding.ASCII.GetBytes("SuperSecretKey12345");
var tokenDescriptor = new SecurityTokenDescriptor {
    Subject = new ClaimsIdentity(new[] { new Claim("id", "1") }),
    Expires = DateTime.UtcNow.AddHours(1),
    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
};
var token = tokenHandler.CreateToken(tokenDescriptor);
Console.WriteLine("Token: " + tokenHandler.WriteToken(token));
