using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/sandbox/transfer/rfp/simulate</c>
/// </summary>
public record SandboxTransferRfpSimulateRequest
{
    /// <summary>
    /// Plaid's unique identifier for a transfer.
    /// </summary>
    [JsonPropertyName("transfer_id")]
    public required string TransferId { get; init; }

    /// <summary>
    /// The action to simulate. Must be either <c>approve</c> or <c>reject</c>.
    /// <list type="bullet">
    ///   <item><description><c>approve</c>: Simulates bank approval, transitioning the transfer to <c>settled</c> status</description></item>
    ///   <item><description><c>reject</c>: Simulates bank rejection, transitioning the transfer to <c>failed</c> status</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("action")]
    public required SandboxTransferRfpSimulateAction Action { get; init; }

    /// <summary>
    /// The transfer amount provided by the caller for validation purposes, must match the amount on the transfer associated with the provided <c>transfer_id</c>.
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// The client name provided by the caller for validation purposes, must match the sender client name on the transfer associated with the provided <c>transfer_id</c>.
    /// </summary>
    [JsonPropertyName("client_name")]
    public required string ClientName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
