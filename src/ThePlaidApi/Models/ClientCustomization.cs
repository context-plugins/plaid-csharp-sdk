using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Custom client fields
/// </summary>
public record ClientCustomization
{
    /// <summary>
    /// Custom entity ID that maps to a merchant or counterparty. This is different from the <c>merchant_entity_id</c> as well as the <c>entity_id</c> on the counterparties object to meet client specific needs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_entity_id")]
    public string? CustomEntityId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
