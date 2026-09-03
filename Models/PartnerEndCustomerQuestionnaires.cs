using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The questionnaires for the end customer.
/// </summary>
public record PartnerEndCustomerQuestionnaires
{
    /// <summary>
    /// The CRA questionnaire for the end customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cra")]
    public PartnerEndCustomerCraQuestionnaire? Cra { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
