using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The failure reason if the type of this transfer is <c>"failed"</c> or <c>"reversed"</c>. Null value otherwise.
/// </summary>
public record BankTransferFailure
{
    /// <summary>
    /// The ACH return code, e.g. <c>R01</c>.  A return code will be provided if and only if the transfer status is <c>reversed</c>. For a full listing of ACH return codes, see <see href="https://plaid.com/docs/errors/bank-transfers/#ach-return-codes">Bank Transfers errors</see>.
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
