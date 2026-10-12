using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the IdentityVerificationAutofillCreate operation.
/// </summary>
public sealed record IdentityVerificationAutofillCreateOperationRequest
{
    public required IdentityVerificationAutofillCreateRequest Body { get; init; }
}
