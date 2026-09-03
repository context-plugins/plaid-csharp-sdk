using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Information about the balance of the ledger held with Plaid.
/// </summary>
public record TransferLedgerBalance
{
    /// <summary>
    /// The amount of this balance available for use (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonPropertyName("available")]
    public required string Available { get; init; }

    /// <summary>
    /// The amount of pending funds that are in processing (decimal string with two digits of precision e.g. "10.00").
    /// </summary>
    [JsonPropertyName("pending")]
    public required string Pending { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
