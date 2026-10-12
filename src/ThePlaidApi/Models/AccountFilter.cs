using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Enumerates the account subtypes that the application wishes for the user to be able to select from. For more details refer to Plaid documentation on account filters.
/// </summary>
public record AccountFilter
{
    /// <summary>
    /// A list of account subtypes to be filtered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("depository")]
    public IReadOnlyList<string>? Depository { get; init; }

    /// <summary>
    /// A list of account subtypes to be filtered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credit")]
    public IReadOnlyList<string>? Credit { get; init; }

    /// <summary>
    /// A list of account subtypes to be filtered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loan")]
    public IReadOnlyList<string>? Loan { get; init; }

    /// <summary>
    /// A list of account subtypes to be filtered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("investment")]
    public IReadOnlyList<string>? Investment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
