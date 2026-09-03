using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object containing liability accounts
/// </summary>
public record LiabilitiesObject
{
    /// <summary>
    /// The credit accounts returned.
    /// </summary>
    [JsonPropertyName("credit")]
    public required IReadOnlyList<CreditCardLiability?> Credit { get; init; }

    /// <summary>
    /// The mortgage accounts returned.
    /// </summary>
    [JsonPropertyName("mortgage")]
    public required IReadOnlyList<MortgageLiability?> Mortgage { get; init; }

    /// <summary>
    /// The student loan accounts returned.
    /// </summary>
    [JsonPropertyName("student")]
    public required IReadOnlyList<StudentLoan?> Student { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
