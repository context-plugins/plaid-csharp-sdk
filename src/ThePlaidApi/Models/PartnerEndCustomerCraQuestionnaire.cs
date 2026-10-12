using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The CRA questionnaire for the end customer.
/// </summary>
public record PartnerEndCustomerCraQuestionnaire
{
    /// <summary>
    /// A map of permissible purposes to their corresponding use cases.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purposes")]
    public PartnerEndCustomerCraPurposes? Purposes { get; init; }

    /// <summary>
    /// Denotes whether the third party is involved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_third_party_involved")]
    public bool? IsThirdPartyInvolved { get; init; }

    /// <summary>
    /// Denotes whether the technical service provider is involved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_technical_service_provider_involved")]
    public bool? IsTechnicalServiceProviderInvolved { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
