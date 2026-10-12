using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
/// </summary>
public record CreditFreddieMacIndividualName
{
    /// <summary>
    /// The first name of the individual represented by the parent object.
    /// </summary>
    [JsonPropertyName("FirstName")]
    public required string FirstName { get; init; }

    /// <summary>
    /// The last name of the individual represented by the parent object.
    /// </summary>
    [JsonPropertyName("LastName")]
    public required string LastName { get; init; }

    /// <summary>
    /// The middle name of the individual represented by the parent object.
    /// </summary>
    [JsonPropertyName("MiddleName")]
    public required string MiddleName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
