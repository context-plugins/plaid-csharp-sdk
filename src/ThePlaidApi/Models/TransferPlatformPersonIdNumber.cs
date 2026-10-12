using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// ID number of the person
/// </summary>
public record TransferPlatformPersonIdNumber
{
    /// <summary>
    /// Value of the person's ID Number. Alpha-numeric, with all formatting characters stripped.
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
