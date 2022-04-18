using APICore.Models;

namespace APICore.Interface
{
    public interface ITokenService
    {
        public string GenerateToken(AuthLogin user);
    }
}
