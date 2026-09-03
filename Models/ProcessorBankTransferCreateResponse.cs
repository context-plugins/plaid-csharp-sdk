using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the response schema for <c>/processor/bank_transfer/create</c>
/// </summary>
public record ProcessorBankTransferCreateResponse
{
    /// <summary>
    /// Represents a bank transfer within the Bank Transfers API.
    /// </summary>
    [JsonPropertyName("bank_transfer")]
    public required BankTransfer BankTransfer { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
