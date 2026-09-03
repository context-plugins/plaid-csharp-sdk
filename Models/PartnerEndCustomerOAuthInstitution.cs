using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The OAuth registration information for an institution.
/// </summary>
public record PartnerEndCustomerOAuthInstitution
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_id")]
    public string? InstitutionId { get; init; }

    /// <summary>
    /// Registration statuses by environment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("environments")]
    public PartnerEndCustomerOAuthInstitutionEnvironments? Environments { get; init; }

    /// <summary>
    /// The date on which the end customer's application was approved by the institution, or an empty string if their application has not yet been approved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("production_enablement_date")]
    public string? ProductionEnablementDate { get; init; }

    /// <summary>
    /// The date on which non-OAuth Item adds will no longer be supported for this institution, or an empty string if no such date has been set by the institution.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("classic_disablement_date")]
    public string? ClassicDisablementDate { get; init; }

    /// <summary>
    /// The errors encountered while registering the end customer's application with the institutions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
