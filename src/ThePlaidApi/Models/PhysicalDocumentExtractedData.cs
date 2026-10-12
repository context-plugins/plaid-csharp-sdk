using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Data extracted from a user-submitted document.
/// </summary>
public record PhysicalDocumentExtractedData
{
    /// <summary>
    /// Alpha-numeric ID number extracted via OCR from the user's document image.
    /// </summary>
    [JsonPropertyName("id_number")]
    public required string? IdNumber { get; init; }

    /// <summary>
    /// The type of identity document detected in the images provided. Will always be one of the following values:
    /// <para>
    ///   <c>drivers_license</c> - A driver's license issued by the associated country, establishing identity without any guarantee as to citizenship, and granting driving privileges
    /// </para>
    /// <para>
    ///   <c>id_card</c> - A general national identification card, distinct from driver's licenses as it only establishes identity
    /// </para>
    /// <para>
    ///   <c>passport</c> - A travel passport issued by the associated country for one of its citizens
    /// </para>
    /// <para>
    ///   <c>residence_permit_card</c> - An identity document issued by the associated country permitting a foreign citizen to &lt;em&gt;temporarily&lt;/em&gt; reside there
    /// </para>
    /// <para>
    ///   <c>resident_card</c> - An identity document issued by the associated country permitting a foreign citizen to &lt;em&gt;permanently&lt;/em&gt; reside there
    /// </para>
    /// <para>
    ///   <c>visa</c> - An identity document issued by the associated country permitting a foreign citizen entry for a short duration and for a specific purpose, typically no longer than 6 months
    /// </para>
    /// <para>
    /// Note: This value may be different from the ID type that the user selects within Link. For example, if they select "Driver's License" but then submit a picture of a passport, this field will say <c>passport</c>
    /// </para>
    /// </summary>
    [JsonPropertyName("category")]
    public required PhysicalDocumentCategory Category { get; init; }

    /// <summary>
    /// The expiration date of the document in the format YYYY-MM-DD (RFC 3339 Section 5.6).
    /// </summary>
    [JsonPropertyName("expiration_date")]
    public required DateTimeOffset? ExpirationDate { get; init; }

    /// <summary>
    /// The issue date of the document in the format YYYY-MM-DD (RFC 3339 Section 5.6).
    /// </summary>
    [JsonPropertyName("issue_date")]
    public required DateTimeOffset? IssueDate { get; init; }

    /// <summary>
    /// Valid, capitalized, two-letter ISO code representing the country of this object. Must be in ISO 3166-1 alpha-2 form.
    /// </summary>
    [JsonPropertyName("issuing_country")]
    public required string IssuingCountry { get; init; }

    /// <summary>
    /// A subdivision code. "Subdivision" is a generic term for "state", "province", "prefecture", "zone", etc. For the list of valid codes, see <see href="https://plaid.com/documents/country_subdivision_codes.json">country subdivision codes</see>. Country prefixes are omitted, since they are inferred from the <c>country</c> field.
    /// </summary>
    [JsonPropertyName("issuing_region")]
    public required string? IssuingRegion { get; init; }

    /// <summary>
    /// A date extracted from the document in the format YYYY-MM-DD (RFC 3339 Section 5.6).
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public required DateTimeOffset? DateOfBirth { get; init; }

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
    [JsonPropertyName("address")]
    public required IdentityVerificationDocumentAddressResponse? Address { get; init; }

    /// <summary>
    /// The individual's name extracted from the document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public IdentityVerificationDocumentNameResponse? Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
