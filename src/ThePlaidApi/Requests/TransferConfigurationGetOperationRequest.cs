using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferConfigurationGet operation.
/// </summary>
public sealed record TransferConfigurationGetOperationRequest
{
    public required TransferConfigurationGetRequest Body { get; init; }
}
