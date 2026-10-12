using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The rationale for Plaid's decision to not guarantee a transfer. Will be <c>null</c> unless <c>guarantee_decision</c> is <c>NOT_GUARANTEED</c>.
/// </summary>
public record TransferAuthorizationGuaranteeDecisionRationale
{
    /// <summary>
    /// A code representing the reason Plaid declined to guarantee this transfer:
    /// <para>
    /// <c>RETURN_BANK</c>: The risk of a bank-initiated return (for example, an R01/NSF) is too high to guarantee this transfer.
    /// </para>
    /// <para>
    /// <c>RETURN_CUSTOMER</c>: The risk of a customer-initiated return (for example, a R10/Unauthorized) is too high to guarantee this transfer.
    /// </para>
    /// <para>
    /// <c>GUARANTEE_LIMIT_REACHED</c>: This transfer is low-risk, but Guarantee has exhausted an internal limit on the number or rate of guarantees that applies to this transfer.
    /// </para>
    /// <para>
    /// <c>RISK_ESTIMATE_UNAVAILABLE</c>: A risk estimate is unavailable for this Item.
    /// </para>
    /// <para>
    /// <c>REQUIRED_PARAM_MISSING</c>: Required fields are missing.
    /// </para>
    /// </summary>
    [JsonPropertyName("code")]
    public required TransferAuthorizationGuaranteeDecisionRationaleCode Code { get; init; }

    /// <summary>
    /// A human-readable description of why the transfer cannot be guaranteed.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
