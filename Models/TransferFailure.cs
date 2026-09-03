using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The failure reason if the event type for a transfer is <c>"failed"</c> or <c>"returned"</c>. Null value otherwise.
/// </summary>
public record TransferFailure
{
    /// <summary>
    /// The failure code, e.g. <c>R01</c>.  A failure code will be provided if and only if the transfer status is <c>returned</c>. See <see href="https://plaid.com/docs/errors/transfer/#ach-return-codes">ACH return codes</see> for a full listing of ACH return codes and <see href="https://plaid.com/docs/errors/transfer/#rtprfp-error-codes">RTP/RfP error codes</see> for RTP error codes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("failure_code")]
    public string? FailureCode { get; init; }

    /// <summary>
    /// The ACH return code, e.g. <c>R01</c>.  A return code will be provided if and only if the transfer status is <c>returned</c>. For a full listing of ACH return codes, see <see href="https://plaid.com/docs/errors/transfer/#ach-return-codes">Transfer errors</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ach_return_code")]
    public string? AchReturnCode { get; init; }

    /// <summary>
    /// A human-readable description of the reason for the failure or reversal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
