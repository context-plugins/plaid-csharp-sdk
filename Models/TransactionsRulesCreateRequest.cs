using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// TransactionsRulesCreateRequest defines the request schema for <c>/beta/transactions/rules/v1/create</c>
/// </summary>
public record TransactionsRulesCreateRequest
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
    /// A unique ID representing the end user. This ID is used to associate rules with a specific user.
    /// </summary>
    [JsonPropertyName("client_user_id")]
    public required string ClientUserId { get; init; }

    /// <summary>
    /// A personal finance primary category.
    /// See the <see href="https://plaid.com/documents/pfc-taxonomy-all.csv">taxonomy csv file</see> for a full list of personal finance categories.
    /// </summary>
    [JsonPropertyName("pfc_primary_category")]
    public required string PfcPrimaryCategory { get; init; }

    /// <summary>
    /// A personal finance detailed category.
    /// See the <see href="https://plaid.com/documents/pfc-taxonomy-all.csv">taxonomy csv file</see> for a full list of personal finance categories.
    /// </summary>
    [JsonPropertyName("pfc_detailed_category")]
    public required string PfcDetailedCategory { get; init; }

    /// <summary>
    /// A representation of transactions rule details.
    /// </summary>
    [JsonPropertyName("rule_details")]
    public required TransactionsRuleDetails RuleDetails { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
