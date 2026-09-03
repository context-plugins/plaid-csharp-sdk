using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the response schema for <c>/bank_transfer/balance/get</c>
/// </summary>
public record BankTransferBalanceGetResponse
{
    /// <summary>
    /// Information about the balance of a bank transfer
    /// </summary>
    [JsonPropertyName("balance")]
    public required BankTransferBalance Balance { get; init; }

    /// <summary>
    /// The ID of the origination account that this balance belongs to.
    /// </summary>
    [JsonPropertyName("origination_account_id")]
    public required string? OriginationAccountId { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
