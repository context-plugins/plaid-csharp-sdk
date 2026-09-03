using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The address extracted from the document. The address must at least contain the following fields to be a valid address: <c>street</c>, <c>city</c>, <c>country</c>. If any are missing or unable to be extracted, the address will be null.
/// <para>
/// <c>region</c>, and <c>postal_code</c> may be null based on the addressing system. For example:
/// </para>
/// <para>
/// Addresses from the United Kingdom will not include a region
/// </para>
/// <para>
/// Addresses from Hong Kong will not include postal code
/// </para>
/// <para>
/// Note: Optical Character Recognition (OCR) technology may sometimes extract incorrect data from a document.
/// </para>
/// </summary>
public record IdentityVerificationDocumentAddressResponse
{
    /// <summary>
    /// The full street address extracted from the document.
    /// </summary>
    [JsonPropertyName("street")]
    public required string Street { get; init; }

    /// <summary>
    /// City extracted from the document.
    /// </summary>
    [JsonPropertyName("city")]
    public required string City { get; init; }

    /// <summary>
    /// A subdivision code extracted from the document. Related terms would be "state", "province", "prefecture", "zone", "subdivision", etc. For a full list of valid codes, see <see href="https://plaid.com/documents/country_subdivision_codes.json">country subdivision codes</see>. Country prefixes are omitted, since they can be inferred from the <c>country</c> field.
    /// </summary>
    [JsonPropertyName("region")]
    public required string? Region { get; init; }

    /// <summary>
    /// The postal code extracted from the document. Between 2 and 10 alphanumeric characters. For US-based addresses this must be 5 numeric digits.
    /// </summary>
    [JsonPropertyName("postal_code")]
    public required string? PostalCode { get; init; }

    /// <summary>
    /// Valid, capitalized, two-letter ISO code representing the country extracted from the document. Must be in ISO 3166-1 alpha-2 form.
    /// </summary>
    [JsonPropertyName("country")]
    public required string Country { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
