using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Describes a consent event.
/// </summary>
public record ConsentEvent
{
    /// <summary>
    /// The Plaid Item ID. The <c>item_id</c> is always unique; linking the same account at the same institution twice will result in two Items with different <c>item_id</c> values. Like all Plaid identifiers, the <c>item_id</c> is case-sensitive.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_id")]
    public string? ItemId { get; init; }

    /// <summary>
    /// The date and time when the consent event occurred, in <see href="https://en.wikipedia.org/wiki/ISO_8601">ISO 8601</see> format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; init; }

    /// <summary>
    /// A broad categorization of the consent event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event_type")]
    public ConsentEventType? EventType { get; init; }

    /// <summary>
    /// Codes describing the object of a consent event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event_code")]
    public ConsentEventCode? EventCode { get; init; }

    /// <summary>
    /// Unique identifier for the institution associated with the Item. Field is <c>null</c> for Items created via Same-Day Micro-deposits.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_id")]
    public string? InstitutionId { get; init; }

    /// <summary>
    /// The full name of the institution associated with the Item. Field is <c>null</c> for Items created via Same-Day Micro-deposits.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_name")]
    public string? InstitutionName { get; init; }

    /// <summary>
    /// The entity that initiated collection of consent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("initiator")]
    public ConsentEventInitiator? Initiator { get; init; }

    /// <summary>
    /// A list of strings containing the full list of use cases the end user has consented to for the Item.
    /// <para>
    /// See the <see href="https://plaid.com/docs/link/data-transparency-messaging-migration-guide/#updating-link-customizations">full list</see> of use cases.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("consented_use_cases")]
    public IReadOnlyList<string>? ConsentedUseCases { get; init; }

    /// <summary>
    /// A list of strings containing the full list of data scopes the end user has consented to for the Item. These correspond to consented products; see the <see href="https://plaid.com/docs/link/data-transparency-messaging-migration-guide/#data-scopes-by-product">full mapping</see> of data scopes and products.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("consented_data_scopes")]
    public IReadOnlyList<string>? ConsentedDataScopes { get; init; }

    /// <summary>
    /// An array containing the accounts associated with the Item for which authorizations are granted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("consented_accounts")]
    public IReadOnlyList<ConsentedAccount>? ConsentedAccounts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
