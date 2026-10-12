using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the response schema for <c>/transfer/originator/funding_account/create</c>
/// </summary>
public record TransferOriginatorFundingAccountCreateResponse
{
    /// <summary>
    /// The id of the funding account to use, available in the Plaid Dashboard. This determines which of your business checking accounts will be credited or debited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("funding_account_id")]
    public string? FundingAccountId { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
