using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The collection of <c>TAXPAYER_IDENTIFICATION</c> elements
/// </summary>
public record TaxpayerIdentifiers
{
    /// <summary>
    /// Information about the Taxpayer identification values assigned to the individual or legal entity.
    /// </summary>
    [JsonPropertyName("TAXPAYER_IDENTIFIER")]
    public required TaxpayerIdentifier TaxpayerIdentifier { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
