using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// ProcessorStripeBankAccountTokenCreateResponse defines the response schema for <c>/processor/stripe/bank_account_token/create</c>
/// </summary>
public record ProcessorStripeBankAccountTokenCreateResponse
{
    /// <summary>
    /// A token that can be sent to Stripe for use in making API calls to Plaid
    /// </summary>
    [JsonPropertyName("stripe_bank_account_token")]
    public required string StripeBankAccountToken { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
