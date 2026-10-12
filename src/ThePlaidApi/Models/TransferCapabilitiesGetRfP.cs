using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Contains the supported service types in RfP
/// </summary>
public record TransferCapabilitiesGetRfP
{
    /// <summary>
    /// When <c>true</c>, the linked Item's institution supports RfP debit transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("debit")]
    public bool? Debit { get; init; } = false;

    /// <summary>
    /// The maximum amount (decimal string with two digits of precision e.g. "10.00") for originating RfP transfers with the given institution.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_amount")]
    public string? MaxAmount { get; init; }

    /// <summary>
    /// The currency of the <c>max_amount</c>, e.g. "USD".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iso_currency_code")]
    public string? IsoCurrencyCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
