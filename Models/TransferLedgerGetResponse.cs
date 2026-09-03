using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the response schema for <c>/transfer/ledger/get</c>
/// </summary>
public record TransferLedgerGetResponse
{
    /// <summary>
    /// The unique identifier of the Ledger that was returned.
    /// </summary>
    [JsonPropertyName("ledger_id")]
    public required string LedgerId { get; init; }

    /// <summary>
    /// Information about the balance of the ledger held with Plaid.
    /// </summary>
    [JsonPropertyName("balance")]
    public required TransferLedgerBalance Balance { get; init; }

    /// <summary>
    /// The name of the Ledger
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Whether this Ledger is the client's default ledger.
    /// </summary>
    [JsonPropertyName("is_default")]
    public required bool IsDefault { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
