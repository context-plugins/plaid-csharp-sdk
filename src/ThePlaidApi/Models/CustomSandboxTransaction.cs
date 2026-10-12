using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Data to populate as test transaction data.
/// </summary>
public record CustomSandboxTransaction
{
    /// <summary>
    /// The date of the transaction, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> (YYYY-MM-DD) format. Transaction date must be the present date or a date up to 14 days in the past. Future dates are not allowed.
    /// </summary>
    [JsonPropertyName("date_transacted")]
    public required DateTimeOffset DateTransacted { get; init; }

    /// <summary>
    /// The date the transaction posted, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> (YYYY-MM-DD) format. Posted date must be the present date or a date up to 14 days in the past. Future dates are not allowed.
    /// </summary>
    [JsonPropertyName("date_posted")]
    public required DateTimeOffset DatePosted { get; init; }

    /// <summary>
    /// The transaction amount. Can be negative.
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }

    /// <summary>
    /// The transaction description.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// The ISO-4217 format currency code for the transaction. Defaults to USD.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iso_currency_code")]
    public string? IsoCurrencyCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
