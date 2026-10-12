using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Metadata related to the recipient. If the information required to populate this field is not available, leave it blank.
/// </summary>
public record LinkDeliveryRecipient
{
    /// <summary>
    /// The list of communication methods to send the Hosted Link session URL to. If delivery is not required, leave this field blank.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("communication_methods")]
    public IReadOnlyList<LinkDeliveryCommunicationMethod>? CommunicationMethods { get; init; }

    /// <summary>
    /// First name of the recipient. Will be used in the body of the email / text (if configured). If this information is not available, leave this field blank.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("first_name")]
    public string? FirstName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
