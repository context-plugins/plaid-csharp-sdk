using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object containing data about a user's bank account related to an uploaded bank statement.
/// </summary>
public record CreditBankStatementUploadBankAccount
{
    /// <summary>
    /// The name of the bank account
    /// </summary>
    [JsonPropertyName("name")]
    public required string? Name { get; init; }

    /// <summary>
    /// The name of the bank institution.
    /// </summary>
    [JsonPropertyName("bank_name")]
    public required string? BankName { get; init; }

    /// <summary>
    /// The type of the bank account.
    /// </summary>
    [JsonPropertyName("account_type")]
    public required string? AccountType { get; init; }

    /// <summary>
    /// The bank account number.
    /// </summary>
    [JsonPropertyName("account_number")]
    public required string? AccountNumber { get; init; }

    /// <summary>
    /// An object containing data about the owner of the bank account for the uploaded bank statement.
    /// </summary>
    [JsonPropertyName("owner")]
    public required CreditBankStatementUploadAccountOwner Owner { get; init; }

    /// <summary>
    /// An array of period objects, containing more data on the overall period of the statement.
    /// </summary>
    [JsonPropertyName("periods")]
    public required IReadOnlyList<CreditBankStatementUploadBankAccountPeriod> Periods { get; init; }

    /// <summary>
    /// The unique id of the bank account
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string? AccountId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
