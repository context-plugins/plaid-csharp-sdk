using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Physical address of a business. Used for input requests.
/// </summary>
public record RequestBusinessAddress
{
    /// <summary>
    /// The primary street portion of an address. If an address is provided, this field will always be filled. A string with at least one non-whitespace alphabetical character, with a max length of 80 characters.
    /// </summary>
    [JsonPropertyName("street")]
    public required string Street { get; init; }

    /// <summary>
    /// Extra street information, like an apartment or suite number. If provided, a string with at least one non-whitespace character, with a max length of 50 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("street2")]
    public string? Street2 { get; init; }

    /// <summary>
    /// City from the address. A string with at least one non-whitespace alphabetical character, with a max length of 100 characters.
    /// </summary>
    [JsonPropertyName("city")]
    public required string City { get; init; }

    /// <summary>
    /// A subdivision code. "Subdivision" is a generic term for "state", "province", "prefecture", "zone", etc. For the list of valid codes, see <see href="https://plaid.com/documents/country_subdivision_codes.json">country subdivision codes</see>. Country prefixes are omitted, since they are inferred from the <c>country</c> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("region")]
    public string? Region { get; init; }

    /// <summary>
    /// The postal code for the associated address. Between 2 and 10 alphanumeric characters. For US-based addresses this must be 5 numeric digits.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postal_code")]
    public string? PostalCode { get; init; }

    /// <summary>
    /// Valid, capitalized, two-letter ISO code representing the country of this object. Must be in ISO 3166-1 alpha-2 form.
    /// </summary>
    [JsonPropertyName("country")]
    public required string Country { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
