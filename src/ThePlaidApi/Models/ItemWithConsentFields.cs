using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Metadata about the Item
/// </summary>
public record ItemWithConsentFields
{
    /// <summary>
    /// The Plaid Item ID. The <c>item_id</c> is always unique; linking the same account at the same institution twice will result in two Items with different <c>item_id</c> values. Like all Plaid identifiers, the <c>item_id</c> is case-sensitive.
    /// </summary>
    [JsonPropertyName("item_id")]
    public required string ItemId { get; init; }

    /// <summary>
    /// The Plaid Institution ID associated with the Item. Field is <c>null</c> for Items created without an institution connection, such as Items created via Same-Day Micro-deposits.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_id")]
    public string? InstitutionId { get; init; }

    /// <summary>
    /// The name of the institution associated with the Item. Field is <c>null</c> for Items created without an institution connection, such as Items created via Same-Day Micro-deposits.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_name")]
    public string? InstitutionName { get; init; }

    /// <summary>
    /// The URL registered to receive webhooks for the Item.
    /// </summary>
    [JsonPropertyName("webhook")]
    public required string? Webhook { get; init; }

    /// <summary>
    /// The method used to populate Auth data for the Item. This field is only populated for Items that have had Auth numbers data set on at least one of their accounts, and will be <c>null</c> otherwise. For info about the various flows, see our <see href="https://plaid.com/docs/auth/coverage/">Auth coverage documentation</see>.
    /// <para>
    /// <c>INSTANT_AUTH</c>: The Item's Auth data was provided directly by the user's institution connection.
    /// </para>
    /// <para>
    /// <c>INSTANT_MATCH</c>: The Item's Auth data was provided via the Instant Match fallback flow.
    /// </para>
    /// <para>
    /// <c>AUTOMATED_MICRODEPOSITS</c>: The Item's Auth data was provided via the Automated Micro-deposits flow.
    /// </para>
    /// <para>
    /// <c>SAME_DAY_MICRODEPOSITS</c>: The Item's Auth data was provided via the Same-Day Micro-deposits flow.
    /// </para>
    /// <para>
    /// <c>INSTANT_MICRODEPOSITS</c>: The Item's Auth data was provided via the Instant Micro-deposits flow.
    /// </para>
    /// <para>
    /// <c>DATABASE_MATCH</c>: The Item's Auth data was provided via the Database Match flow.
    /// </para>
    /// <para>
    /// <c>DATABASE_INSIGHTS</c>: The Item's Auth data was provided via the Database Insights flow.
    /// </para>
    /// <para>
    /// <c>TRANSFER_MIGRATED</c>: The Item's Auth data was provided via <see href="https://plaid.com/docs/api/products/transfer/account-linking/#migrate-account-into-transfers"><c>/transfer/migrate_account</c></see>.
    /// </para>
    /// <para>
    /// <c>INVESTMENTS_FALLBACK</c>: The Item's Auth data for Investments Move was provided via a <see href="https://plaid.com/docs/investments-move/#fallback-flows">fallback flow</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auth_method")]
    public ItemAuthMethod? AuthMethod { get; init; }

    /// <summary>
    /// Errors are identified by <c>error_code</c> and categorized by <c>error_type</c>. Use these in preference to HTTP status codes to identify and handle specific errors. HTTP status codes are set and provide the broadest categorization of errors: 4xx codes are for developer- or user-related errors, and 5xx codes are for Plaid-related errors, and the status will be 2xx in non-error cases. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.
    /// </summary>
    [JsonPropertyName("error")]
    public required Error? Error { get; init; }

    /// <summary>
    /// A list of products available for the Item that have not yet been accessed. The contents of this array will be mutually exclusive with <c>billed_products</c>.
    /// </summary>
    [JsonPropertyName("available_products")]
    public required IReadOnlyList<Products> AvailableProducts { get; init; }

    /// <summary>
    /// A list of products that have been billed for the Item. The contents of this array will be mutually exclusive with <c>available_products</c>. Note - <c>billed_products</c> is populated in all environments but only requests in Production are billed. Also note that products that are billed on a pay-per-call basis rather than a pay-per-Item basis, such as <c>balance</c>, will not appear here.
    /// </summary>
    [JsonPropertyName("billed_products")]
    public required IReadOnlyList<Products> BilledProducts { get; init; }

    /// <summary>
    /// A list of products added to the Item. In almost all cases, this will be the same as the <c>billed_products</c> field. For some products, it is possible for the product to be added to an Item but not yet billed (e.g. Assets, before <c>/asset_report/create</c> has been called, or Auth or Identity when added as Optional Products but before their endpoints have been called), in which case the product may appear in <c>products</c> but not in <c>billed_products</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("products")]
    public IReadOnlyList<Products>? Products { get; init; }

    /// <summary>
    /// A list of products that the user has consented to for the Item via <see href="https://plaid.com/docs/link/data-transparency-messaging-migration-guide">Data Transparency Messaging</see>. This will consist of all products where both of the following are true: the user has consented to the required data scopes for that product and you have Production access for that product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("consented_products")]
    public IReadOnlyList<Products>? ConsentedProducts { get; init; }

    /// <summary>
    /// The date and time at which the Item's access consent will expire, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format. If the Item does not have consent expiration scheduled, this field will be <c>null</c>. Currently, only institutions in Europe and a small number of institutions in the US have expiring consent. For a list of US institutions that currently expire consent, see the <see href="https://plaid.com/docs/link/oauth/#refreshing-item-consent">OAuth Guide</see>.
    /// </summary>
    [JsonPropertyName("consent_expiration_time")]
    public required DateTimeOffset? ConsentExpirationTime { get; init; }

    /// <summary>
    /// Indicates whether an Item requires user interaction to be updated, which can be the case for Items with some forms of two-factor authentication.
    /// <para>
    /// <c>background</c> - Item can be updated in the background
    /// </para>
    /// <para>
    /// <c>user_present_required</c> - Item requires user interaction to be updated
    /// </para>
    /// </summary>
    [JsonPropertyName("update_type")]
    public required UpdateType UpdateType { get; init; }

    /// <summary>
    /// The date and time when the Item was created, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; init; }

    /// <summary>
    /// A list of use cases that the user has consented to for the Item via <see href="https://plaid.com/docs/link/data-transparency-messaging-migration-guide">Data Transparency Messaging</see>.
    /// <para>
    /// You can see the full list of use cases or update the list of use cases to request at any time via the Link Customization section of the <see href="https://dashboard.plaid.com/link/data-transparency-v5">Plaid Dashboard</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("consented_use_cases")]
    public IReadOnlyList<string>? ConsentedUseCases { get; init; }

    /// <summary>
    /// A list of data scopes that the user has consented to for the Item via <see href="https://plaid.com/docs/link/data-transparency-messaging-migration-guide">Data Transparency Messaging</see>. These are based on the <c>consented_products</c>; see the <see href="https://plaid.com/docs/link/data-transparency-messaging-migration-guide/#data-scopes-by-product">full mapping</see> of data scopes and products.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("consented_data_scopes")]
    public IReadOnlyList<ConsentedDataScope>? ConsentedDataScopes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
