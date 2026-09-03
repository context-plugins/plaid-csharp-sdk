using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Identifying information for transferring holdings to an investment account via ACATS.
/// </summary>
public record NumbersAcats
{
    /// <summary>
    /// The Plaid account ID associated with the account numbers
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The full account number for the account
    /// </summary>
    [JsonPropertyName("account")]
    public required string Account { get; init; }

    /// <summary>
    /// Identifiers for the clearinghouses that are associated with the account in order of relevance. If this array is empty, call <c>/institutions/get_by_id</c> with the <c>item.institution_id</c> to get the DTC number.
    /// </summary>
    [JsonPropertyName("dtc_numbers")]
    public required IReadOnlyList<string> DtcNumbers { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
