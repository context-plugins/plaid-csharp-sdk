using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// SignalReturnReportRequest defines the request schema for <c>/signal/return/report</c>
/// </summary>
public record SignalReturnReportRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// Must be the same as the <c>client_transaction_id</c> supplied when calling <c>/signal/evaluate</c>.
    /// </summary>
    [JsonPropertyName("client_transaction_id")]
    [StringLength(36, MinimumLength = 1)]
    public required string ClientTransactionId { get; init; }

    /// <summary>
    /// Must be a valid ACH return code (e.g. "R01")
    /// <para>
    /// If formatted incorrectly, this will result in an <see href="https://plaid.com/docs/errors/invalid-request/#invalid_field"><c>INVALID_FIELD</c></see> error.
    /// </para>
    /// </summary>
    [JsonPropertyName("return_code")]
    public required string ReturnCode { get; init; }

    /// <summary>
    /// Date and time when you receive the returns from your payment processors, in ISO 8601 format (<c>YYYY-MM-DDTHH:mm:ssZ</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("returned_at")]
    public DateTimeOffset? ReturnedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
