using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A client-provided transaction that Plaid has enriched.
/// </summary>
public record ClientProvidedEnrichedTransaction
{
    /// <summary>
    /// The unique ID for the transaction as provided by you in the request.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// A unique user id used to group transactions for a given user, as a unique identifier from your application. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_user_id")]
    public string? ClientUserId { get; init; }

    /// <summary>
    /// A unique account id used to group transactions for a given account, as a unique identifier from your application. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_account_id</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_account_id")]
    public string? ClientAccountId { get; init; }

    /// <summary>
    /// The account type associated with the transaction. For a full list of valid types and subtypes, see the <see href="https://plaid.com/docs/api/accounts#account-type-schema">Account schema</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_type")]
    public string? AccountType { get; init; }

    /// <summary>
    /// The account subtype associated with the transaction. For a full list of valid types and subtypes, see the <see href="https://plaid.com/docs/api/accounts#account-type-schema">Account schema</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_subtype")]
    public string? AccountSubtype { get; init; }

    /// <summary>
    /// The raw description of the transaction.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// The absolute value of the transaction (&gt;= 0)
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }

    /// <summary>
    /// The direction of the transaction from the perspective of the account holder:
    /// <para>
    /// <c>OUTFLOW</c> - Includes outgoing transfers, purchases, and fees. (Typically represented as a negative value on checking accounts and debit cards and a positive value on credit cards.)
    /// </para>
    /// <para>
    /// <c>INFLOW</c> - Includes incoming transfers, refunds, and income. (Typically represented as a positive value on checking accounts and debit cards and a negative value on credit cards.)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("direction")]
    public EnrichTransactionDirection? Direction { get; init; }

    /// <summary>
    /// The ISO-4217 currency code of the transaction e.g. USD.
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string IsoCurrencyCode { get; init; }

    /// <summary>
    /// A grouping of the Plaid produced transaction enrichment fields.
    /// </summary>
    [JsonPropertyName("enrichments")]
    public required Enrichments Enrichments { get; init; }

    /// <summary>
    /// Custom client fields
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_customization")]
    public ClientCustomization? ClientCustomization { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
