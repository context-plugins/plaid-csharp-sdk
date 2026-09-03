using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Life span for the payment consent. After the <c>to</c> date the payment consent expires and can no longer be used for payment initiation.
/// </summary>
public record PaymentConsentValidDateTime
{
    /// <summary>
    /// The date and time from which the consent should be active, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("from")]
    public DateTimeOffset? From { get; init; }

    /// <summary>
    /// The date and time at which the consent expires, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("to")]
    public DateTimeOffset? To { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
