using Bitspco.Framework.Filters.Security.Authenticate;

namespace ERP.PMS.Facade.Filters
{
    class Authenticator : IAuthenticator
    {
        public string Token { get; set; }

        public string GetToken()
        {
            return Token;
        }

        public bool HasPermission(string policy)
        {
            return true;
        }

        public bool IsTokenValid()
        {
            return true;
        }
    }
}
