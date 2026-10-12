using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the InstitutionsSearch operation.
/// </summary>
public sealed record InstitutionsSearchOperationRequest
{
    public required InstitutionsSearchRequest Body { get; init; }
}
