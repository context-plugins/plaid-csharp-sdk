using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// PaymentInitiationRecipientListRequest defines the request schema for <c>/payment_initiation/recipient/list</c>
/// </summary>
public record PaymentInitiationRecipientListRequest
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
    /// The maximum number of recipients to return. If <c>count</c> is not specified, a maximum of 100 recipients will be returned, beginning with the recipient at the cursor (if specified).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("count")]
    [Minimum(1)]
    [Maximum(100)]
    public int? Count { get; init; } = 100;

    /// <summary>
    /// A value representing the latest recipient to be included in the response. Set this from <c>next_cursor</c> received from the previous <c>/payment_initiation/recipient/list</c> request. If provided, the response will only contain that recipient and recipients created before it. If omitted, the response will contain recipients starting from the most recent, and in descending order by the <c>created_at</c> time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    [MaxLength(256)]
    public string? Cursor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
