using IdentityModel.Client;

namespace IdentityServer4DemoMVC.Service
{
    public interface ITokenService
    {
        Task<TokenResponse> GetToken(string scope);
    }
}
