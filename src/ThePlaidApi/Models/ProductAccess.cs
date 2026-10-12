using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The product access being requested. Used to allow or disallow product access across all accounts. If unset, defaults to all products allowed.
/// </summary>
public record ProductAccess
{
    /// <summary>
    /// Allow access to statements. Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statements")]
    public bool? Statements { get; init; } = true;

    /// <summary>
    /// Allow access to the Identity product (name, email, phone, address). Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("identity")]
    public bool? Identity { get; init; } = true;

    /// <summary>
    /// Allow access to account number details. Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auth")]
    public bool? Auth { get; init; } = true;

    /// <summary>
    /// Allow access to transaction details. Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactions")]
    public bool? Transactions { get; init; } = true;

    /// <summary>
    /// Allow access to <c>accounts_details_transactions</c>. Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accounts_details_transactions")]
    public bool? AccountsDetailsTransactions { get; init; } = true;

    /// <summary>
    /// Allow access to <c>accounts_routing_number</c>. Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accounts_routing_number")]
    public bool? AccountsRoutingNumber { get; init; } = true;

    /// <summary>
    /// Allow access to <c>accounts_statements</c>. Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accounts_statements")]
    public bool? AccountsStatements { get; init; } = true;

    /// <summary>
    /// Allow access to <c>accounts_tax_statements</c>. Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accounts_tax_statements")]
    public bool? AccountsTaxStatements { get; init; } = true;

    /// <summary>
    /// Allow access to <c>customers_profiles</c>. Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customers_profiles")]
    public bool? CustomersProfiles { get; init; } = true;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
