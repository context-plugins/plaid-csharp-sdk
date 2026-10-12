using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object containing data that has been parsed from a user-uploaded bank statement.
/// </summary>
public record CreditBankStatementUploadObject
{
    /// <summary>
    /// An array of transactions appearing on the bank statement.
    /// </summary>
    [JsonPropertyName("transactions")]
    public required IReadOnlyList<CreditBankStatementUploadTransaction> Transactions { get; init; }

    /// <summary>
    /// Object representing metadata pertaining to the document.
    /// </summary>
    [JsonPropertyName("document_metadata")]
    public required CreditDocumentMetadata DocumentMetadata { get; init; }

    /// <summary>
    /// An identifier of the document referenced by the document metadata.
    /// </summary>
    [JsonPropertyName("document_id")]
    public required string? DocumentId { get; init; }

    /// <summary>
    /// An array of bank accounts associated with the uploaded bank statement.
    /// </summary>
    [JsonPropertyName("bank_accounts")]
    public required IReadOnlyList<CreditBankStatementUploadBankAccount> BankAccounts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
