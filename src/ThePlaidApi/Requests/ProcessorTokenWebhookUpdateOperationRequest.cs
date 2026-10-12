using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProcessorTokenWebhookUpdate operation.
/// </summary>
public sealed record ProcessorTokenWebhookUpdateOperationRequest
{
    public required ProcessorTokenWebhookUpdateRequest Body { get; init; }
}
