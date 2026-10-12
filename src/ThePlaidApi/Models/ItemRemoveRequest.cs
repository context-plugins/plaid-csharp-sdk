using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// ItemRemoveRequest defines the request schema for <c>/item/remove</c>
/// </summary>
public record ItemRemoveRequest
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
    /// The access token associated with the Item for which data is being requested.
    /// </summary>
    [JsonPropertyName("access_token")]
    public required string AccessToken { get; init; }

    /// <summary>
    /// The reason for removing the Item
    /// <para>
    /// <c>FRAUD_FIRST_PARTY</c>: The end user who owns the connected bank account committed fraud
    /// <c>FRAUD_FALSE_IDENTITY</c>: The end user created the connection using false identity information or stolen credentials
    /// <c>FRAUD_ABUSE</c>: The end user is abusing the client's service or platform through their connected account
    /// <c>FRAUD_OTHER</c>: Other fraud-related reasons involving the end user not covered by the specific fraud categories
    /// <c>CONNECTION_IS_NON_FUNCTIONAL</c>: The connection to the end user's financial institution is broken and cannot be restored
    /// <c>OTHER</c>: Any other reason for removing the connection not covered by the above categories
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason_code")]
    public ItemRemoveReasonCode? ReasonCode { get; init; }

    /// <summary>
    /// Additional context or details about the reason for removing the Item. Personally identifiable information, such as an email address or phone number, should not be included in the <c>reason_note</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason_note")]
    [MaxLength(512)]
    public string? ReasonNote { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
