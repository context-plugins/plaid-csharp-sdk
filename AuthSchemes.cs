using ThePlaidApi.Core;
using ThePlaidApi.Core.Authentication;
using ThePlaidApi.Core.Authentication.ApiKey;
using ThePlaidApi.Core.Authentication.OAuth2;
using ThePlaidApi.Core.Authentication.OAuth2.ClientCredentials;

namespace ThePlaidApi;

internal sealed class AuthSchemes
{
    public IAuthScheme ClientId { get; }
    public IAuthScheme Secret { get; }
    public IAuthScheme PlaidVersion { get; }
    public IAuthScheme Oauth2 { get; }

    public AuthSchemes(ThePlaidApiClientOptions options, Server server, RawClient rawClient)
    {
        ClientId = ApiKeyHeaderScheme.Create("PLAID-CLIENT-ID", options.ClientId);
        Secret = ApiKeyHeaderScheme.Create("PLAID-SECRET", options.Secret);
        PlaidVersion = ApiKeyHeaderScheme.Create("Plaid-Version", options.PlaidVersion);
        Oauth2 =
            OAuth2Scheme<OAuth2ClientCredentials>.Create(options.Oauth2,
                options.Oauth2TokenStrategy ??
                    OAuth2ClientCredentialsStrategy.ForBasicAuthRequest(server.AccessTokenServer("/token"), rawClient));
    }
}
