using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the StatementsDownload operation.
/// </summary>
public sealed record StatementsDownloadOperationRequest
{
    public required StatementsDownloadRequest Body { get; init; }
}
