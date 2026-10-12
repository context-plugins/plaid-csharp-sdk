using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A repayment is created automatically after one or more guaranteed transactions receive a return. If there are multiple eligible returns in a day, they are batched together into a single repayment.
/// <para>
/// Repayments are sent over ACH, with funds typically available on the next banking day.
/// </para>
/// </summary>
public record TransferRepayment
{
    /// <summary>
    /// Identifier of the repayment.
    /// </summary>
    [JsonPropertyName("repayment_id")]
    public required string RepaymentId { get; init; }

    /// <summary>
    /// The datetime when the repayment occurred, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("created")]
    public required DateTimeOffset Created { get; init; }

    /// <summary>
    /// Decimal amount of the repayment as it appears on your account ledger.
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
