using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Parent container for name that allows for choice group between parsed and unparsed containers.
/// </summary>
public record Name
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
