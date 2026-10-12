using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// InvestmentsHoldingsGetResponse defines the response schema for <c>/investments/holdings/get</c>
/// </summary>
public record InvestmentsHoldingsGetResponse
{
    /// <summary>
    /// The accounts associated with the Item
    /// </summary>
    [JsonPropertyName("accounts")]
    public required IReadOnlyList<InvestmentAccount> Accounts { get; init; }

    /// <summary>
    /// The holdings belonging to investment accounts associated with the Item. Details of the securities in the holdings are provided in the <c>securities</c> field.
    /// </summary>
    [JsonPropertyName("holdings")]
    public required IReadOnlyList<Holding> Holdings { get; init; }

    /// <summary>
    /// Objects describing the securities held in the accounts associated with the Item.
    /// </summary>
    [JsonPropertyName("securities")]
    public required IReadOnlyList<Security> Securities { get; init; }

    /// <summary>
    /// Metadata about the Item.
    /// </summary>
    [JsonPropertyName("item")]
    public required Item Item { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// When true, this field indicates that the Item's portfolio was manually created with the Investments Fallback flow.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_investments_fallback_item")]
    public bool? IsInvestmentsFallbackItem { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
