using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the PartnerCustomerOauthInstitutionsGet operation.
/// </summary>
public sealed record PartnerCustomerOauthInstitutionsGetOperationRequest
{
    public required PartnerCustomerOAuthInstitutionsGetRequest Body { get; init; }
}
