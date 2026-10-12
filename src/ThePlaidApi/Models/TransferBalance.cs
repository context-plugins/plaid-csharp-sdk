using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Information about the balance held with Plaid.
/// </summary>
public record TransferBalance
{
    /// <summary>
    /// The amount of this balance available for use (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonPropertyName("available")]
    public required string Available { get; init; }

    /// <summary>
    /// The available balance, plus the amount of pending funds that are in processing (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("current")]
    public string? Current { get; init; }

    /// <summary>
    /// The type of balance.
    /// <para>
    /// <c>prefunded_rtp_credits</c> - Your prefunded RTP credit balance with Plaid
    /// <c>prefunded_ach_credits</c> - Your prefunded ACH credit balance with Plaid
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required TransferBalanceType Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
