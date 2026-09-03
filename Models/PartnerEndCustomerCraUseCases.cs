using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The list of use cases associated with a given permissible purpose.
/// </summary>
public record PartnerEndCustomerCraUseCases
{
    /// <summary>
    /// List of use cases for the given permissible purpose.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("use_cases")]
    public IReadOnlyList<PartnerEndCustomerCraUseCase>? UseCases { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
