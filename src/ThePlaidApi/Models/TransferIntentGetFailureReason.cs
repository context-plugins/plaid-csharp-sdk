using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The reason for a failed transfer intent. Returned only if the transfer intent status is <c>failed</c>. Null otherwise.
/// </summary>
public record TransferIntentGetFailureReason
{
    /// <summary>
    /// A broad categorization of the error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error_type")]
    public string? ErrorType { get; init; }

    /// <summary>
    /// A code representing the reason for a failed transfer intent (i.e., an API error or the authorization being declined).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error_code")]
    public string? ErrorCode { get; init; }

    /// <summary>
    /// A human-readable description of the code associated with a failed transfer intent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error_message")]
    public string? ErrorMessage { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
