using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// ProcessorInvestmentsAuthGetResponse defines the response schema for <c>/processor/investments/auth/get</c>
/// </summary>
public record ProcessorInvestmentsAuthGetResponse
{
    /// <summary>
    /// A single account at a financial institution.
    /// </summary>
    [JsonPropertyName("account")]
    public required Account Account { get; init; }

    /// <summary>
    /// The holdings belonging to the investment account. Details of the securities in the holdings are provided in the <c>securities</c> field.
    /// </summary>
    [JsonPropertyName("holdings")]
    public required IReadOnlyList<Holding> Holdings { get; init; }

    /// <summary>
    /// Objects describing the securities held in the account.
    /// </summary>
    [JsonPropertyName("securities")]
    public required IReadOnlyList<Security> Securities { get; init; }

    /// <summary>
    /// Information about the account owners for the account.
    /// </summary>
    [JsonPropertyName("owners")]
    public required IReadOnlyList<InvestmentsAuthOwner> Owners { get; init; }

    /// <summary>
    /// Identifying information for transferring holdings to an investment account.
    /// </summary>
    [JsonPropertyName("numbers")]
    public required InvestmentsAuthGetNumbers Numbers { get; init; }

    /// <summary>
    /// Object with metadata pertaining to the source of data for the account numbers, owners, and holdings that are returned.
    /// </summary>
    [JsonPropertyName("data_sources")]
    public required InvestmentsAuthDataSources DataSources { get; init; }

    /// <summary>
    /// Additional information for accounts of 401k subtype.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_details_401k")]
    public IReadOnlyList<InvestmentsAuthAccountDetails401K>? AccountDetails401K { get; init; }

    /// <summary>
    /// When true, this field indicates that the Item's portfolio was manually created with the Investments Fallback flow.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_investments_fallback_item")]
    public bool? IsInvestmentsFallbackItem { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
