using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing a filer used by 1099-K tax documents.
/// </summary>
public record Credit1099Filer
{
    /// <summary>
    /// Address on the pay stub.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public CreditPayStubAddress? Address { get; init; }

    /// <summary>
    /// Name of filer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Tax identification number of filer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tin")]
    public string? Tin { get; init; }

    /// <summary>
    /// One of the following values will be provided: Payment Settlement Entity (PSE), Electronic Payment Facilitator (EPF), Other Third Party
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
