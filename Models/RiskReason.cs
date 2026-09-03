using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// This object includes a code and description to describe medium risk transactions and above on <c>/accounts/balance/get</c>.
/// </summary>
public record RiskReason
{
    /// <summary>
    /// A code that represents the type of risk associated with the proposed transaction.
    /// <para>
    /// The codes are from PL01 to PL08 and from BK01 to BK07. For a full listing of risk reason codes, see <see href="https://plaid.com/docs/balance/balance-plus/#risk-codes">Risk codes</see>.
    /// </para>
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; init; }

    /// <summary>
    /// A human-readable description explaining the risk code associated with the proposed transaction and some recommended actions. This field is subject to change; any programmatic logic should be based on the <c>code</c> field instead.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
