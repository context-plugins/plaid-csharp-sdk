using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A set of fields describing the investments data on an account.
/// </summary>
public record BaseReportInvestments
{
    /// <summary>
    /// Quantities and values of securities held in the investment account. Map to the <c>securities</c> array for security details.
    /// </summary>
    [JsonPropertyName("holdings")]
    public required IReadOnlyList<BaseReportInvestmentHolding> Holdings { get; init; }

    /// <summary>
    /// Details of specific securities held in the investment account.
    /// </summary>
    [JsonPropertyName("securities")]
    public required IReadOnlyList<BaseReportInvestmentSecurity> Securities { get; init; }

    /// <summary>
    /// Transaction history on the investment account.
    /// </summary>
    [JsonPropertyName("investment_transactions")]
    public required IReadOnlyList<BaseReportInvestmentTransaction> InvestmentTransactions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
