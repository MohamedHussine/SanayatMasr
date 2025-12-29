using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/test/hash")]
public class HashTestController : ControllerBase
{
    private readonly IPasswordHasher _passwordHasher;

    public HashTestController(IPasswordHasher passwordHasher)
    {
        _passwordHasher = passwordHasher;
    }

    [HttpGet("{password}")]
    public IActionResult Hash(string password)
    {
        var hash = _passwordHasher.Hash(password);
        return Ok(new
        {
            Password = password,
            Hash = hash
        });
    }
}

