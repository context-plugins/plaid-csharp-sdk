using ThePlaidApi.Core.Models;
using ThePlaidApi.Servers;

namespace ThePlaidApi;

public class Server
{
    private readonly ServerEnvironment _environment;
    private readonly ServerOptions _options;

    internal Server(ServerEnvironment environment, ServerOptions options)
    {
        _environment = environment;
        _options = options;
    }

    internal UrlTemplate Default(string path) => _options.Default.Resolve(_environment, path);
    internal UrlTemplate AccessTokenServer(string path) =>
        _options.AccessTokenServer.Resolve(_environment, path);
}
