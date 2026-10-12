using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the PartnerCustomerGet operation.
/// </summary>
public sealed record PartnerCustomerGetOperationRequest
{
    public required PartnerCustomerGetRequest Body { get; init; }
}
