using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the LinkDeliveryCreate operation.
/// </summary>
public sealed record LinkDeliveryCreateOperationRequest
{
    public required LinkDeliveryCreateRequest Body { get; init; }
}
