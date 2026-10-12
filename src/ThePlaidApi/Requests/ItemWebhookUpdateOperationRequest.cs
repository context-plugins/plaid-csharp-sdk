using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ItemWebhookUpdate operation.
/// </summary>
public sealed record ItemWebhookUpdateOperationRequest
{
    public required ItemWebhookUpdateRequest Body { get; init; }
}
