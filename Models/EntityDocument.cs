using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An official document, usually issued by a governing body or institution, with an associated identifier.
/// </summary>
public record EntityDocument
{
    /// <summary>
    /// The kind of official document represented by this object.
    /// <para>
    /// <c>bik</c> - Russian bank code
    /// </para>
    /// <para>
    /// <c>business_number</c> - A number that uniquely identifies the business within a category of businesses
    /// </para>
    /// <para>
    /// <c>imo</c> - Number assigned to the entity by the International Maritime Organization
    /// </para>
    /// <para>
    /// <c>other</c> - Any document not covered by other categories
    /// </para>
    /// <para>
    /// <c>swift</c> - Number identifying a bank and branch.
    /// </para>
    /// <para>
    /// <c>tax_id</c> - Identification issued for the purpose of collecting taxes
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required EntityDocumentType Type { get; init; }

    /// <summary>
    /// The numeric or alphanumeric identifier associated with this document. Must be between 4 and 32 characters long, and cannot have leading or trailing spaces.
    /// </summary>
    [JsonPropertyName("number")]
    public required string Number { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
