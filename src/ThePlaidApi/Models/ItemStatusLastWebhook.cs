using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Information about the last webhook fired for the Item.
/// </summary>
public record ItemStatusLastWebhook
{
    /// <summary>
    /// <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> timestamp of when the webhook was fired.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sent_at")]
    public DateTimeOffset? SentAt { get; init; }

    /// <summary>
    /// The last webhook code sent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code_sent")]
    public string? CodeSent { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
