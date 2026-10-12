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

    private static SandboxTransactionsCreateError AsError(Error? value) => new(Optional<Error?>.Some(value), default);

    private static SandboxTransactionsCreateError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error? value) => _errorValue.TryGetValue(out value);

    private static Task<SandboxTransactionsCreateError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<Error?>().As(AsError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<SandboxTransactionsCreateError> Response { get; } = new(Create);
}
