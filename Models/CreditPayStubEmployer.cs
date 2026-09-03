using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Information about the employer on the pay stub.
/// </summary>
public record CreditPayStubEmployer
{
    /// <summary>
    /// Address on the pay stub.
    /// </summary>
    [JsonPropertyName("address")]
    public required CreditPayStubAddress Address { get; init; }

    /// <summary>
    /// The name of the employer on the pay stub.
    /// </summary>
    [JsonPropertyName("name")]
    public required string? Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
