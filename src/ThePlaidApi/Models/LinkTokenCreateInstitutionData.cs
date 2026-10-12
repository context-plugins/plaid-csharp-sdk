using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A map containing data used to highlight institutions in Link.
/// </summary>
public record LinkTokenCreateInstitutionData
{
    /// <summary>
    /// The routing number of the bank to highlight in Link. Note: in rare cases, a single routing number can be associated with multiple institutions, e.g. due to a brokerage using another institution to manage ACH on its sweep accounts. If this happens, the bank will not be highlighted in Link even if the routing number is provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("routing_number")]
    public string? RoutingNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
