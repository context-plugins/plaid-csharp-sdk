using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Metadata about the CRA Credit Profile Report.
/// </summary>
public record CraCreditProfileReportMetadata
{
    /// <summary>
    /// The number of items used to calculate the report.
    /// </summary>
    [JsonPropertyName("item_count")]
    public required int ItemCount { get; init; }

    /// <summary>
    /// The institution IDs associated with the report.
    /// </summary>
    [JsonPropertyName("institution_ids")]
    public required IReadOnlyList<string> InstitutionIds { get; init; }

    /// <summary>
    /// The total number of accounts in the report.
    /// </summary>
    [JsonPropertyName("account_count")]
    public required int AccountCount { get; init; }

    /// <summary>
    /// The number of primary accounts in the report.
    /// </summary>
    [JsonPropertyName("primary_account_count")]
    public required int PrimaryAccountCount { get; init; }

    /// <summary>
    /// The number of depository accounts in the report.
    /// </summary>
    [JsonPropertyName("depository_account_type_count")]
    public required int DepositoryAccountTypeCount { get; init; }

    /// <summary>
    /// The number of credit accounts in the report.
    /// </summary>
    [JsonPropertyName("credit_account_type_count")]
    public required int CreditAccountTypeCount { get; init; }

    /// <summary>
    /// The number of other accounts in the report.
    /// </summary>
    [JsonPropertyName("other_account_type_count")]
    public required int OtherAccountTypeCount { get; init; }

    /// <summary>
    /// The number of accounts with multiple owners in the report.
    /// </summary>
    [JsonPropertyName("multiple_owner_account_count")]
    public required int MultipleOwnerAccountCount { get; init; }

    /// <summary>
    /// The time when the report was generated.
    /// </summary>
    [JsonPropertyName("generated_at")]
    public required DateTimeOffset GeneratedAt { get; init; }

    /// <summary>
    /// The date of the oldest transaction in the report.
    /// </summary>
    [JsonPropertyName("oldest_transaction_date")]
    public required DateTimeOffset OldestTransactionDate { get; init; }

    /// <summary>
    /// The date of the most recent transaction in the report.
    /// </summary>
    [JsonPropertyName("most_recent_transaction_date")]
    public required DateTimeOffset MostRecentTransactionDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
