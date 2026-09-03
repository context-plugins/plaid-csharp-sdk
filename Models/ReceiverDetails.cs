using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Additional details for receiver events. Currently always <c>null</c>.
/// </summary>
public record ReceiverDetails
{
    /// <summary>
    /// The available balance associated with the receiver event.
    /// </summary>
    [JsonPropertyName("available_balance")]
    public required string? AvailableBalance { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
