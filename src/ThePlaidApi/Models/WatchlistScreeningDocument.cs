using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An official document, usually issued by a governing body or institution, with an associated identifier.
/// </summary>
public record WatchlistScreeningDocument
{
    /// <summary>
    /// The kind of official document represented by this object.
    /// <para>
    /// <c>birth_certificate</c> - A certificate of birth
    /// </para>
    /// <para>
    /// <c>drivers_license</c> - A license to operate a motor vehicle
    /// </para>
    /// <para>
    /// <c>immigration_number</c> - Immigration or residence documents
    /// </para>
    /// <para>
    /// <c>military_id</c> - Identification issued by a military group
    /// </para>
    /// <para>
    /// <c>other</c> - Any document not covered by other categories
    /// </para>
    /// <para>
    /// <c>passport</c> - An official passport issued by a government
    /// </para>
    /// <para>
    /// <c>personal_identification</c> - Any generic personal identification that is not covered by other categories
    /// </para>
    /// <para>
    /// <c>ration_card</c> - Identification that entitles the holder to rations
    /// </para>
    /// <para>
    /// <c>ssn</c> - United States Social Security Number
    /// </para>
    /// <para>
    /// <c>student_id</c> - Identification issued by an educational institution
    /// </para>
    /// <para>
    /// <c>tax_id</c> - Identification issued for the purpose of collecting taxes
    /// </para>
    /// <para>
    /// <c>travel_document</c> - Visas, entry permits, refugee documents, etc.
    /// </para>
    /// <para>
    /// <c>voter_id</c> - Identification issued for the purpose of voting
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required WatchlistScreeningDocumentType Type { get; init; }

    /// <summary>
    /// The numeric or alphanumeric identifier associated with this document. Must be between 4 and 32 characters long, and cannot have leading or trailing spaces.
    /// </summary>
    [JsonPropertyName("number")]
    public required string Number { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
