using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the IdentityDocumentsUploadsGet operation.
/// </summary>
public sealed record IdentityDocumentsUploadsGetOperationRequest
{
    public required IdentityDocumentsUploadsGetRequest Body { get; init; }
}
