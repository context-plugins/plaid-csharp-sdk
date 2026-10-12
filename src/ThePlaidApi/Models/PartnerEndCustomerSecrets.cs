using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The secrets for the newly created end customer.
/// </summary>
public record PartnerEndCustomerSecrets
{
    /// <summary>
    /// The end customer's secret key for the Sandbox environment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sandbox")]
    public string? Sandbox { get; init; }

    /// <summary>
    /// The end customer's secret key for the Development environment. The Development environment has been removed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("development")]
    public string? Development { get; init; }

    /// <summary>
    /// The end customer's secret key for the Production environment. The end customer will be provided with a limited number of credits to test in the Production environment before full enablement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("production")]
    public string? Production { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
