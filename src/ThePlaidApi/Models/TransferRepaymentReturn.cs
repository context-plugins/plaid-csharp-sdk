using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// Represents a return on a Guaranteed ACH transfer that is included in the specified repayment.
/// </summary>
public record TransferRepaymentReturn
{
    /// <summary>
    /// The unique identifier of the guaranteed transfer that was returned.
    /// </summary>
    [JsonPropertyName("transfer_id")]
    public required string TransferId { get; init; }

    /// <summary>
    /// The unique identifier of the corresponding <c>returned</c> transfer event.
    /// </summary>
    [JsonPropertyName("event_id")]
    [Minimum(0)]
    public required int EventId { get; init; }

    /// <summary>
    /// The value of the returned transfer.
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// The currency of the repayment, e.g. "USD".
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string IsoCurrencyCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
