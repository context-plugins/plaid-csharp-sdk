using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

public record IdNumber
{
    /// <summary>
    /// Value of the identity document typed in by the user. Alpha-numeric, with all formatting characters stripped. For specific format requirements by ID type, see <see href="https://plaid.com/docs/identity-verification/hybrid-input-validation/#id-numbers">Input Validation Rules</see>.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; init; }

    /// <summary>
    /// A globally unique and human readable ID type, specific to the country and document category. For more context on this field, see <see href="https://plaid.com/docs/identity-verification/hybrid-input-validation/#id-numbers">Input Validation Rules</see>.
    /// </summary>
    [JsonPropertyName("type")]
    public required IdNumberType Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
