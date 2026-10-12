using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxTransactionsCreate operation.
/// </summary>
public sealed record SandboxTransactionsCreateOperationRequest
{
    public required SandboxTransactionsCreateRequest Body { get; init; }
}
