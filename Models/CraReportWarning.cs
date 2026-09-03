using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// It is possible for a Check Report product to be returned with missing information. In such cases, the product will contain warning data in the response, indicating why some of the requested information could not be retrieved.
/// </summary>
public record CraReportWarning
{
    /// <summary>
    /// The warning type, which will always be <c>CHECK_REPORT_WARNING</c>
    /// </summary>
    [JsonPropertyName("warning_type")]
    public required string WarningType { get; init; }

    /// <summary>
    /// The warning code identifies a specific kind of warning.
    /// <c>IDENTITY_UNAVAILABLE</c>:  Account-owner information is not available.
    /// <c>TRANSACTIONS_UNAVAILABLE</c>: Transactions information associated with Credit and Depository accounts are unavailable.
    /// <c>USER_FRAUD_ALERT</c>: The user has placed a fraud alert on their Plaid Check consumer report due to suspected fraud. Please note that when a fraud alert is in place, the recipient of the consumer report has an obligation to verify the consumer's identity.
    /// </summary>
    [JsonPropertyName("warning_code")]
    public required CheckReportWarningCode WarningCode { get; init; }

    /// <summary>
    /// An error object and associated <c>item_id</c> used to identify a specific Item and error when a batch operation operating on multiple Items has encountered an error in one of the Items.
    /// </summary>
    [JsonPropertyName("cause")]
    public required Cause? Cause { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
