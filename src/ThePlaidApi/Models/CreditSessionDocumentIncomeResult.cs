using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The details of a document income verification in Link
/// </summary>
public record CreditSessionDocumentIncomeResult
{
    /// <summary>
    /// The number of paystubs uploaded by the user.
    /// </summary>
    [JsonPropertyName("num_paystubs_uploaded")]
    public required int NumPaystubsUploaded { get; init; }

    /// <summary>
    /// The number of w2s uploaded by the user.
    /// </summary>
    [JsonPropertyName("num_w2s_uploaded")]
    public required int NumW2SUploaded { get; init; }

    /// <summary>
    /// The number of bank statements uploaded by the user.
    /// </summary>
    [JsonPropertyName("num_bank_statements_uploaded")]
    public required int NumBankStatementsUploaded { get; init; }

    /// <summary>
    /// The number of 1099s uploaded by the user
    /// </summary>
    [JsonPropertyName("num_1099s_uploaded")]
    public required int Num1099SUploaded { get; init; }

    /// <summary>
    /// The number of I-20s uploaded by the user
    /// </summary>
    [JsonPropertyName("num_i20s_uploaded")]
    public required int NumI20SUploaded { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
