using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Home address of a person
/// </summary>
public record TransferPlatformPersonAddress
{
    /// <summary>
    /// The full city name.
    /// </summary>
    [JsonPropertyName("city")]
    public required string City { get; init; }

    /// <summary>
    /// Valid, capitalized, two-letter ISO code representing the country of this object. Must be in ISO 3166-1 alpha-2 form.
    /// </summary>
    [JsonPropertyName("country")]
    public required string Country { get; init; }

    /// <summary>
    /// The postal code of the address.
    /// </summary>
    [JsonPropertyName("postal_code")]
    public required string PostalCode { get; init; }

    /// <summary>
    /// An ISO 3166-2 subdivision code.
    /// Related terms would be "state", "province", "prefecture", "zone", "subdivision", etc.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; init; }

    /// <summary>
    /// The primary street portion of an address. A string with at least one non-whitespace alphabetical character, with a max length of 80 characters.
    /// </summary>
    [JsonPropertyName("street")]
    public required string Street { get; init; }

    /// <summary>
    /// Extra street information, like an apartment or suite number. If provided, a string with at least one non-whitespace character, with a max length of 50 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("street2")]
    public string? Street2 { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
