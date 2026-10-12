using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferDiligenceSubmit operation.
/// </summary>
public sealed record TransferDiligenceSubmitOperationRequest
{
    public required TransferDiligenceSubmitRequest Body { get; init; }
}
