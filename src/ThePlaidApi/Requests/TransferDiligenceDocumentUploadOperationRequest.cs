using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferDiligenceDocumentUpload operation.
/// </summary>
public sealed record TransferDiligenceDocumentUploadOperationRequest
{
    public required TransferDiligenceDocumentUploadRequest Body { get; init; }
}
