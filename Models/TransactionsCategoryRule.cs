using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A representation of a transactions category rule.
/// </summary>
public record TransactionsCategoryRule
{
    /// <summary>
    /// A unique identifier of the rule created
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The Plaid-generated unique identifier for the end user this rule belongs to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }

    /// <summary>
    /// Date and time when a rule was created in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format ( <c>YYYY-MM-DDTHH:mm:ssZ</c> ).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; init; }

    /// <summary>
    /// Date and time when a rule was last updated in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format ( <c>YYYY-MM-DDTHH:mm:ssZ</c> ).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public DateTimeOffset? UpdatedAt { get; init; }

    /// <summary>
    /// A personal finance primary category.
    /// See the <see href="https://plaid.com/documents/pfc-taxonomy-all.csv">taxonomy csv file</see> for a full list of personal finance categories.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pfc_primary_category")]
    public string? PfcPrimaryCategory { get; init; }

    /// <summary>
    /// A personal finance detailed category.
    /// See the <see href="https://plaid.com/documents/pfc-taxonomy-all.csv">taxonomy csv file</see> for a full list of personal finance categories.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pfc_detailed_category")]
    public string? PfcDetailedCategory { get; init; }

    /// <summary>
    /// A representation of transactions rule details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rule_details")]
    public TransactionsRuleDetails? RuleDetails { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
