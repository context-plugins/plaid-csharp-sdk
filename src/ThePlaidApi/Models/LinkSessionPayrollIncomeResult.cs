using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The details of a digital payroll income verification in Link.
/// </summary>
public record LinkSessionPayrollIncomeResult
{
    /// <summary>
    /// The number of paystubs retrieved from a payroll provider.
    /// </summary>
    [JsonPropertyName("num_paystubs_retrieved")]
    public required int NumPaystubsRetrieved { get; init; }

    /// <summary>
    /// The number of W-2s retrieved from a payroll provider.
    /// </summary>
    [JsonPropertyName("num_w2s_retrieved")]
    public required int NumW2SRetrieved { get; init; }

    /// <summary>
    /// An institution object. If the Item was created via Same-Day or Instant micro-deposit verification, will be <c>null</c>.
    /// </summary>
    [JsonPropertyName("institution")]
    public required LinkSessionSuccessMetadataInstitution? Institution { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
