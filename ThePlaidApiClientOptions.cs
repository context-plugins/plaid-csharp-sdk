using System.Collections.Generic;
using ThePlaidApi.Core.Authentication.OAuth2;
using ThePlaidApi.Core.Authentication.OAuth2.ClientCredentials;
using ThePlaidApi.Core.Configuration;
using ThePlaidApi.Core.Hooks;
using ThePlaidApi.Servers;

namespace ThePlaidApi;

public class ThePlaidApiClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
    public IReadOnlyList<SdkHook> Hooks { get; set; } = [];
    public string? ClientId { get; set; }
    public string? Secret { get; set; }
    public string? PlaidVersion { get; set; }
    /// <summary>
    /// The Plaid API supports client credentials, authorization code, and custom delegation flows.
    /// </summary>
    public OAuth2ClientCredentials? Oauth2 { get; set; }
    public IOAuth2TokenStrategy<OAuth2ClientCredentials>? Oauth2TokenStrategy { get; set; }
}
