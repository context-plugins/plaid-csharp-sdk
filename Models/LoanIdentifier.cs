using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The information used to identify this loan by various parties to the transaction or other organizations.
/// </summary>
public record LoanIdentifier
{
    /// <summary>
    /// The value of the identifier for the specified type.
    /// </summary>
    [JsonPropertyName("LoanIdentifier")]
    public required string? LoanIdentifierValue { get; init; }

    /// <summary>
    /// A value from a MISMO prescribed list that specifies the type of loan identifier.
    /// </summary>
    [JsonPropertyName("LoanIdentifierType")]
    public required LoanIdentifierType? LoanIdentifierType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
