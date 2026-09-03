using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Registration statuses by environment.
/// </summary>
public record PartnerEndCustomerOAuthInstitutionEnvironments
{
    /// <summary>
    /// The registration status for the end customer's application.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("development")]
    public PartnerEndCustomerOAuthInstitutionApplicationStatus? Development { get; init; }

    /// <summary>
    /// The registration status for the end customer's application.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("production")]
    public PartnerEndCustomerOAuthInstitutionApplicationStatus? Production { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
