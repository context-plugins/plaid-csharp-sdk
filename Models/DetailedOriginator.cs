using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Originator and their status.
/// </summary>
public record DetailedOriginator
{
    /// <summary>
    /// Originator's client ID.
    /// </summary>
    [JsonPropertyName("client_id")]
    public required string ClientId { get; init; }

    /// <summary>
    /// Originator's diligence status.
    /// </summary>
    [JsonPropertyName("transfer_diligence_status")]
    public required TransferDiligenceStatus TransferDiligenceStatus { get; init; }

    /// <summary>
    /// The company name of the end customer.
    /// </summary>
    [JsonPropertyName("company_name")]
    public required string CompanyName { get; init; }

    /// <summary>
    /// List of outstanding requirements that must be submitted before Plaid can approve the originator. Only populated when <c>transfer_diligence_status</c> is <c>more_information_required</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("outstanding_requirements")]
    public IReadOnlyList<TransferPlatformRequirement>? OutstandingRequirements { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
