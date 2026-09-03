using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ThePlaidApi.Core.ErrorResponse;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models;

namespace ThePlaidApi.Errors;

public sealed class SandboxTransactionsCreateError : ApiError
{
    private readonly Optional<Error?> _errorValue;

    private SandboxTransactionsCreateError(Optional<Error?> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SandboxTransactionsCreateError AsError(Error? value) =>
        new(Optional<Error?>.Some(value), default);

    private static SandboxTransactionsCreateError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error? value) => _errorValue.TryGetValue(out value);

    internal static Task<SandboxTransactionsCreateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error?>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SandboxTransactionsCreateErrorResponse : IErrorResponse<SandboxTransactionsCreateError>
{
    public static SandboxTransactionsCreateErrorResponse Instance { get; } = new();

    private SandboxTransactionsCreateErrorResponse()
    {
    }

    public Task<SandboxTransactionsCreateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SandboxTransactionsCreateError.Create(response, ct);
}
