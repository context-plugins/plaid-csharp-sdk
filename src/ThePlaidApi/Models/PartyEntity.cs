using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// FDX Participant - an entity or person that is a part of a FDX API transaction
/// </summary>
public record PartyEntity
{
    /// <summary>
    /// Human recognizable common name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Identifies the type of a party
    /// </summary>
    [JsonPropertyName("type")]
    public required PartyType Type { get; init; }

    /// <summary>
    /// URI for party, where an end user could learn more about the company or application involved in the data sharing chain
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("homeUri")]
    [Format(FormatKind.Uri)]
    public string? HomeUri { get; init; }

    /// <summary>
    /// URI for a logo asset to be displayed to the end user
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logoUri")]
    [Format(FormatKind.Uri)]
    public string? LogoUri { get; init; }

    /// <summary>
    /// The registry containing the party's registration with name and id
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("registry")]
    public PartyRegistry? Registry { get; init; }

    /// <summary>
    /// Registered name of party
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("registeredEntityName")]
    public string? RegisteredEntityName { get; init; }

    /// <summary>
    /// Registered id of party
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("registeredEntityId")]
    public string? RegisteredEntityId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
