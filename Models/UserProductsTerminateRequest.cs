using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// UserProductsTerminateRequest defines the request schema for <c>/user/products/terminate</c>
/// </summary>
public record UserProductsTerminateRequest
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
    /// A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <see href="https://plaid.com/docs/api/users/user-apis">New User APIs</see>.
    /// </summary>
    [JsonPropertyName("user_id")]
    public required string UserId { get; init; }

    /// <summary>
    /// The reason for terminating products.
    /// <para>
    /// <c>FRAUD_FIRST_PARTY</c>: The end user who owns the connected bank account committed fraud using their real identity
    /// <c>FRAUD_FALSE_IDENTITY</c>: The connection was created using a false or stolen identity
    /// <c>FRAUD_ABUSE</c>: The end user is abusing the client's service or platform (for example, automation or excessive retries) through their connected account
    /// <c>FRAUD_OTHER</c>: Fraud-related, but not covered by the specific fraud categories above; <c>reason_note</c> should clarify
    /// <c>FRAUD_TRANSACTION</c>: Fraud occurred at the transaction level, such as an unauthorized transaction, card testing, chargeback, ACH return, or dispute
    /// <c>CONSUMER_LOAN_PAID_OFF</c>: The end user paid off their loan and no longer needs the product
    /// <c>CONSUMER_ACCOUNT_CLOSED</c>: The end user closed their account with the client and no longer needs the product
    /// <c>CONSUMER_CHARGE_OFF</c>: The end user's account has been charged off
    /// <c>CONSUMER_PAYMENT_METHOD_SWITCHED</c>: The end user switched to a different payment method and no longer needs the product
    /// <c>USER_OFFBOARDING</c>: The user is offboarding from the client's service or platform
    /// <c>DUPLICATE_ITEM</c>: This Item is a duplicate of another active Item for the same user
    /// <c>BILLING_TERMINATION</c>: The client's billing or subscription relationship with the end user has ended
    /// <c>OTHER</c>: None of the above; <c>reason_note</c> should clarify
    /// </para>
    /// </summary>
    [JsonPropertyName("reason_code")]
    public required ProductsTerminateReasonCode ReasonCode { get; init; }

    /// <summary>
    /// Additional context or details about the reason for terminating user-based products. Personally identifiable information, such as an email address or phone number, should not be included in the <c>reason_note</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason_note")]
    [MaxLength(512)]
    public string? ReasonNote { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
