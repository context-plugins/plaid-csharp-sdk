using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Assets under management for the given end customer. Required for end customers with monthly service commitments.
/// </summary>
public record PartnerEndCustomerAssetsUnderManagement
{
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }

    [JsonPropertyName("iso_currency_code")]
    public required string IsoCurrencyCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
