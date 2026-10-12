using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferAuthorizationCancel operation.
/// </summary>
public sealed record TransferAuthorizationCancelOperationRequest
{
    public required TransferAuthorizationCancelRequest Body { get; init; }
}
