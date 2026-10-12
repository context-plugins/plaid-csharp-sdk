using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProtectEventGet operation.
/// </summary>
public sealed record ProtectEventGetOperationRequest
{
    public required ProtectEventGetRequest Body { get; init; }
}
