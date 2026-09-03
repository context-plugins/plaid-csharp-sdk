using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the response schema for <c>/transfer/ledger/withdraw</c>
/// </summary>
public record TransferLedgerWithdrawResponse
{
    /// <summary>
    /// Describes a sweep of funds to / from the sweep account.
    /// <para>
    /// A sweep is associated with many sweep events (events of type <c>swept</c> or <c>return_swept</c>) which can be retrieved by invoking the <c>/transfer/event/list</c> endpoint with the corresponding <c>sweep_id</c>.
    /// </para>
    /// <para>
    /// <c>swept</c> events occur when the transfer amount is credited or debited from your sweep account, depending on the <c>type</c> of the transfer. <c>return_swept</c> events occur when a transfer is returned and Plaid undoes the credit or debit.
    /// </para>
    /// <para>
    /// The total sum of the <c>swept</c> and <c>return_swept</c> events is equal to the <c>amount</c> of the sweep Plaid creates and matches the amount of the entry on your sweep account ledger.
    /// </para>
    /// </summary>
    [JsonPropertyName("sweep")]
    public required TransferSweep Sweep { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
