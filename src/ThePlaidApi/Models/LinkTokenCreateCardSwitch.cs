using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A map containing data to pass in for the Card Switch flow.
/// </summary>
public record LinkTokenCreateCardSwitch
{
    /// <summary>
    /// The BIN (Bank Identification Number) of the card to switch.
    /// </summary>
    [JsonPropertyName("card_bin")]
    public required string CardBin { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
