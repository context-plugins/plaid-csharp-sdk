using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The details of a document upload CRA session in Link
/// </summary>
public record LinkSessionCraDocumentUploadResult
{
    /// <summary>
    /// The number of bank statements uploaded by the user.
    /// </summary>
    [JsonPropertyName("num_bank_statements_uploaded")]
    public required int NumBankStatementsUploaded { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
