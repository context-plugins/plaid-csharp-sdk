using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the LinkDeliveryGet operation.
/// </summary>
public sealed record LinkDeliveryGetOperationRequest
{
    public required LinkDeliveryGetRequest Body { get; init; }
}
