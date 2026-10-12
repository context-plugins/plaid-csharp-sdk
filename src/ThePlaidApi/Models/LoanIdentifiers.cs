using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Collection of current and previous identifiers for this loan.
/// </summary>
public record LoanIdentifiers
{
    /// <summary>
    /// The information used to identify this loan by various parties to the transaction or other organizations.
    /// </summary>
    [JsonPropertyName("LOAN_IDENTIFIER")]
    public required LoanIdentifier LoanIdentifier { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
