using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the PartnerCustomerCreate operation.
/// </summary>
public sealed record PartnerCustomerCreateOperationRequest
{
    public required PartnerCustomerCreateRequest Body { get; init; }
}
