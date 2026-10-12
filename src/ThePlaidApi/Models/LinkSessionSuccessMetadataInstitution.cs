using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An institution object. If the Item was created via Same-Day or Instant micro-deposit verification, will be <c>null</c>.
/// </summary>
public record LinkSessionSuccessMetadataInstitution
{
    /// <summary>
    /// The full institution name, such as <c>'Wells Fargo'</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The Plaid institution identifier
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_id")]
    public string? InstitutionId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
