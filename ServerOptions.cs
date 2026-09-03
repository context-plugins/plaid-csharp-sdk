using ThePlaidApi.Servers;

namespace ThePlaidApi;

public class ServerOptions
{
    public DefaultOptions Default { get; set; } = new();
    public AccessTokenServerOptions AccessTokenServer { get; set; } = new();
}
