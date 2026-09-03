using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A collection of loans that are part of a single deal.
/// </summary>
public record CreditFreddieMacLoans
{
    /// <summary>
    /// Information specific to a mortgage loan agreement between one or more borrowers and a mortgage lender.
    /// </summary>
    [JsonPropertyName("LOAN")]
    public required CreditFreddieMacLoan Loan { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
