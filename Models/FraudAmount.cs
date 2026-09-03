using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The amount and currency of the fraud or attempted fraud.
/// <c>fraud_amount</c> should be omitted to indicate an unknown fraud amount.
/// </summary>
public record FraudAmount
{
    /// <summary>
    /// An ISO-4217 currency code.
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public string IsoCurrencyCode { get; } = "USD";

    /// <summary>
    /// The amount value.
    /// This value can be 0 to indicate no money was lost.
    /// Must not contain more than two digits of precision (e.g., <c>1.23</c>).
    /// </summary>
    [JsonPropertyName("value")]
    public required double Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
