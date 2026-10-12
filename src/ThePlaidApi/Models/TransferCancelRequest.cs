using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/transfer/cancel</c>
/// </summary>
public record TransferCancelRequest
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
    /// Plaid's unique identifier for a transfer.
    /// </summary>
    [JsonPropertyName("transfer_id")]
    public required string TransferId { get; init; }

    /// <summary>
    /// The Plaid client ID of the transfer originator. Should only be present if <c>client_id</c> is a third-party sender (TPS).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originator_client_id")]
    public string? OriginatorClientId { get; init; }

    /// <summary>
    /// Specifies the reason for cancelling transfer. This is required for RfP transfers, and will be ignored for other networks.
    /// <para>
    /// <c>"AC03"</c> - Invalid Creditor Account Number
    /// </para>
    /// <para>
    /// <c>"AM09"</c> - Incorrect Amount
    /// </para>
    /// <para>
    /// <c>"CUST"</c> - Requested By Customer - Cancellation requested
    /// </para>
    /// <para>
    /// <c>"DUPL"</c> - Duplicate Payment
    /// </para>
    /// <para>
    /// <c>"FRAD"</c> - Fraudulent Payment - Unauthorized or fraudulently induced
    /// </para>
    /// <para>
    /// <c>"TECH"</c> - Technical Problem - Cancellation due to system issues
    /// </para>
    /// <para>
    /// <c>"UPAY"</c> - Undue Payment - Payment was made through another channel
    /// </para>
    /// <para>
    /// <c>"AC14"</c> - Invalid or Missing Creditor Account Type
    /// </para>
    /// <para>
    /// <c>"AM06"</c> - Amount Too Low
    /// </para>
    /// <para>
    /// <c>"BE05"</c> - Unrecognized Initiating Party
    /// </para>
    /// <para>
    /// <c>"FOCR"</c> - Following Refund Request
    /// </para>
    /// <para>
    /// <c>"MS02"</c> - No Specified Reason - Customer
    /// </para>
    /// <para>
    /// <c>"MS03"</c> - No Specified Reason - Agent
    /// </para>
    /// <para>
    /// <c>"RR04"</c> - Regulatory Reason
    /// </para>
    /// <para>
    /// <c>"RUTA"</c> - Return Upon Unable To Apply
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason_code")]
    public ReasonCode? ReasonCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
