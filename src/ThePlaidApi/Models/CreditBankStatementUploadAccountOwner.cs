using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object containing data about the owner of the bank account for the uploaded bank statement.
/// </summary>
public record CreditBankStatementUploadAccountOwner
{
    /// <summary>
    /// The name of the account owner
    /// </summary>
    [JsonPropertyName("name")]
    public required string? Name { get; init; }

    /// <summary>
    /// Address on the uploaded bank statement
    /// </summary>
    [JsonPropertyName("address")]
    public required CreditBankStatementUploadAccountOwnerAddress Address { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
