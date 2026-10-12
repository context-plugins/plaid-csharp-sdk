using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Optional metadata related to the Hosted Link session
/// </summary>
public record LinkDeliveryOptions
{
    /// <summary>
    /// Metadata related to the recipient. If the information required to populate this field is not available, leave it blank.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recipient")]
    public LinkDeliveryRecipient? Recipient { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
