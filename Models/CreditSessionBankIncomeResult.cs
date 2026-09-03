using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The details of a bank income verification in Link
/// </summary>
public record CreditSessionBankIncomeResult
{
    /// <summary>
    /// Status of the Bank Income Link session.
    /// <para>
    /// <c>APPROVED</c>: User has approved and verified their income
    /// </para>
    /// <para>
    /// <c>NO_DEPOSITS_FOUND</c>: We attempted, but were unable to find any income in the connected account.
    /// </para>
    /// <para>
    /// <c>USER_REPORTED_NO_INCOME</c>: The user explicitly indicated that they don't receive income in the connected account.
    /// </para>
    /// <para>
    /// <c>STARTED</c>: The user began the bank income portion of the link flow.
    /// </para>
    /// <para>
    /// <c>INTERNAL_ERROR</c>: The user encountered an internal error.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public CreditSessionBankIncomeStatus? Status { get; init; }

    /// <summary>
    /// The Plaid Item ID. The <c>item_id</c> is always unique; linking the same account at the same institution twice will result in two Items with different <c>item_id</c> values. Like all Plaid identifiers, the <c>item_id</c> is case-sensitive.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_id")]
    public string? ItemId { get; init; }

    /// <summary>
    /// The Plaid Institution ID associated with the Item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_id")]
    public string? InstitutionId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
