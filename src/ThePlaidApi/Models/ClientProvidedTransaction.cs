using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A client-provided transaction for Plaid to enrich.
/// </summary>
public record ClientProvidedTransaction
{
    /// <summary>
    /// A unique ID for the transaction used to help you tie data back to your systems.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The Plaid generated ID that identifies the end user for whom you would like to enrich transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }

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
    /// The raw description of the transaction. If you have location data in available an unstructured format, it may be appended to the <c>description</c> field.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// The absolute value of the transaction (&gt;= 0). When testing Enrich, note that <c>amount</c> data should be realistic. Unrealistic or inaccurate <c>amount</c> data may result in reduced quality output.
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
    [JsonPropertyName("direction")]
    public required EnrichTransactionDirection Direction { get; init; }

    /// <summary>
    /// The ISO-4217 currency code of the transaction e.g. USD.
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string IsoCurrencyCode { get; init; }

    /// <summary>
    /// A representation of where a transaction took place.
    /// <para>
    /// Use this field to pass in structured location information you may have about your transactions. Providing location data is optional but can increase result quality. If you have unstructured location information, it may be appended to the <c>description</c> field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public ClientProvidedTransactionLocation? Location { get; init; }

    /// <summary>
    /// Merchant category codes (MCCs) are four-digit numbers that describe a merchant's primary business activities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mcc")]
    public string? Mcc { get; init; }

    /// <summary>
    /// The date the transaction posted, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> (YYYY-MM-DD) format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date_posted")]
    public DateTimeOffset? DatePosted { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
