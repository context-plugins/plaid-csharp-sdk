using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// GetRecipientsResponse defines the response schema for <c>/fdx/recipients</c>
/// </summary>
public record GetRecipientsResponse
{
    [JsonPropertyName("recipients")]
    public required IReadOnlyList<ExtendedRecipientMetadata> Recipients { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
