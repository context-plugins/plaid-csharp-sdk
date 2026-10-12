using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the AuthVerify operation.
/// </summary>
public sealed record AuthVerifyOperationRequest
{
    public required AuthVerifyRequest Body { get; init; }
}
