using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The monetary amount associated with the incident.
/// </summary>
public record ProtectIncidentAmount
{
    /// <summary>
    /// The ISO-4217 currency code of the incident amount. Defaults to <c>USD</c> if not specified.
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public string? IsoCurrencyCode { get; init; } = "USD";

    /// <summary>
    /// The monetary value of the incident amount.
    /// </summary>
    [JsonPropertyName("value")]
    public required double Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
