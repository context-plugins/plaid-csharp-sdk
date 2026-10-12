using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProcessorTokenPermissionsGet operation.
/// </summary>
public sealed record ProcessorTokenPermissionsGetOperationRequest
{
    public required ProcessorTokenPermissionsGetRequest Body { get; init; }
}
