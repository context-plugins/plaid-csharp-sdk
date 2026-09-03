using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object with information about the status of the Item.
/// </summary>
public record ItemStatus
{
    /// <summary>
    /// Information about the last successful and failed investments update for the Item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("investments")]
    public ItemStatusInvestments? Investments { get; init; }

    /// <summary>
    /// Information about the last successful and failed transactions update for the Item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactions")]
    public ItemStatusTransactions? Transactions { get; init; }

    /// <summary>
    /// Information about the last webhook fired for the Item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_webhook")]
    public ItemStatusLastWebhook? LastWebhook { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
