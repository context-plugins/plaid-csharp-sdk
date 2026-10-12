using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object to be used with the request. If specified, <c>options</c> must not be <c>null</c>.
/// </summary>
public record ProcessorTransactionsGetRequestOptions
{
    /// <summary>
    /// The number of transactions to fetch.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("count")]
    [Minimum(1)]
    [Maximum(500)]
    public int? Count { get; init; } = 100;

    /// <summary>
    /// The number of transactions to skip. The default value is 0.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("offset")]
    [Minimum(0)]
    public int? Offset { get; init; } = 0;

    /// <summary>
    /// Include the raw unparsed transaction description from the financial institution.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_original_description")]
    public bool? IncludeOriginalDescription { get; init; } = false;

    /// <summary>
    /// Personal finance categories are now returned by default.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_personal_finance_category_beta")]
    public bool? IncludePersonalFinanceCategoryBeta { get; init; } = false;

    /// <summary>
    /// Personal finance categories are now returned by default.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_personal_finance_category")]
    public bool? IncludePersonalFinanceCategory { get; init; } = false;

    /// <summary>
    /// Counterparties and extra merchant fields are now returned by default.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_logo_and_counterparty_beta")]
    public bool? IncludeLogoAndCounterpartyBeta { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
