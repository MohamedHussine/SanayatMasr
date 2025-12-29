
using System.Security.Cryptography;
using System.Text;
using DataAccess.Interfaces;

public class PasswordHasher : IPasswordHasher
{
    public string Hash(string password)
    {
        using var sha = SHA256.Create();
        return Convert.ToBase64String(
            sha.ComputeHash(Encoding.UTF8.GetBytes(password)));
    }

    public bool Verify(string password, string hash)
        => Hash(password) == hash;
}
