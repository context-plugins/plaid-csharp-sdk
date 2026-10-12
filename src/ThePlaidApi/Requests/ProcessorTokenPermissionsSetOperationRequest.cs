using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProcessorTokenPermissionsSet operation.
/// </summary>
public sealed record ProcessorTokenPermissionsSetOperationRequest
{
    public required ProcessorTokenPermissionsSetRequest Body { get; init; }
}
