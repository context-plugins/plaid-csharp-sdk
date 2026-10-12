using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProcessorStripeBankAccountTokenCreate operation.
/// </summary>
public sealed record ProcessorStripeBankAccountTokenCreateOperationRequest
{
    public required ProcessorStripeBankAccountTokenCreateRequest Body { get; init; }
}
