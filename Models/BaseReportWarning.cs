using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// It is possible for a Base Report to be returned with missing account owner information. In such cases, the Base Report will contain warning data in the response, indicating why obtaining the owner information failed.
/// </summary>
public record BaseReportWarning
{
    /// <summary>
    /// The warning type, which will always be <c>BASE_REPORT_WARNING</c>
    /// </summary>
    [JsonPropertyName("warning_type")]
    public required string WarningType { get; init; }

    /// <summary>
    /// The warning code identifies a specific kind of warning.
    /// <c>IDENTITY_UNAVAILABLE</c>: Account-owner information is not available.
    /// <c>TRANSACTIONS_UNAVAILABLE</c>: Transactions information associated with Credit and Depository accounts are unavailable.
    /// <c>USER_FRAUD_ALERT</c>: The User has placed a fraud alert on their Plaid Check consumer report due to suspected fraud. Note: when a fraud alert is in place, the recipient of the consumer report has an obligation to verify the consumer's identity.
    /// </summary>
    [JsonPropertyName("warning_code")]
    public required BaseReportWarningCode WarningCode { get; init; }

    /// <summary>
    /// An error object and associated <c>item_id</c> used to identify a specific Item and error when a batch operation operating on multiple Items has encountered an error in one of the Items.
    /// </summary>
    [JsonPropertyName("cause")]
    public required Cause? Cause { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
