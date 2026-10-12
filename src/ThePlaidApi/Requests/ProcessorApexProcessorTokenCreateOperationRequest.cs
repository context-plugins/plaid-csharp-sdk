using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProcessorApexProcessorTokenCreate operation.
/// </summary>
public sealed record ProcessorApexProcessorTokenCreateOperationRequest
{
    public required ProcessorApexProcessorTokenCreateRequest Body { get; init; }
}
