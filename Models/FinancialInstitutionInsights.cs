using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Insights surrounding external financial institution counterparties associated with a user.
/// </summary>
public record FinancialInstitutionInsights
{
    /// <summary>
    /// Name of the financial institution counterparty.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// A unique, stable, Plaid-generated id that maps to the counterparty.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entity_id")]
    public string? EntityId { get; init; }

    /// <summary>
    /// The website associated with the counterparty.
    /// </summary>
    [JsonPropertyName("website")]
    public required string? Website { get; init; }

    /// <summary>
    /// Associated accounts, detected based on the nature of transfers to/from this institution.
    /// </summary>
    [JsonPropertyName("detected_accounts")]
    public required IReadOnlyList<DetectedAccount> DetectedAccounts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
