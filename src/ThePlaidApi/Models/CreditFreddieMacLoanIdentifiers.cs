using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Collection of current and previous identifiers for this loan.
/// </summary>
public record CreditFreddieMacLoanIdentifiers
{
    [JsonPropertyName("LOAN_IDENTIFIER")]
    public required IReadOnlyList<LoanIdentifier> LoanIdentifier { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
