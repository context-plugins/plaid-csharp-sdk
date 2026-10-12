using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferCapabilitiesGet operation.
/// </summary>
public sealed record TransferCapabilitiesGetOperationRequest
{
    public required TransferCapabilitiesGetRequest Body { get; init; }
}
