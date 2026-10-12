using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A set of fields describing the investments data on an account.
/// </summary>
public record AssetReportInvestments
{
    /// <summary>
    /// Quantities and values of securities held in the investment account. Map to the <c>securities</c> array for security details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("holdings")]
    public IReadOnlyList<AssetReportInvestmentHolding>? Holdings { get; init; }

    /// <summary>
    /// Details of specific securities held in on the investment account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("securities")]
    public IReadOnlyList<AssetReportInvestmentSecurity>? Securities { get; init; }

    /// <summary>
    /// Transaction history on the investment account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactions")]
    public IReadOnlyList<AssetReportInvestmentTransaction>? Transactions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
