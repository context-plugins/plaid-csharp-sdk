using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Detailed information about the business from data provider results
/// </summary>
public record BusinessKybMatchDetails
{
    /// <summary>
    /// Names associated with the business.
    /// </summary>
    [JsonPropertyName("names")]
    public required IReadOnlyList<ProviderBusinessName> Names { get; init; }

    /// <summary>
    /// The legal structure or type of business entity
    /// </summary>
    [JsonPropertyName("entity_type")]
    public required BusinessEntityType? EntityType { get; init; }

    /// <summary>
    /// Addresses associated with the business
    /// </summary>
    [JsonPropertyName("addresses")]
    public required IReadOnlyList<ProviderBusinessAddress> Addresses { get; init; }

    /// <summary>
    /// Phone numbers associated with the business
    /// </summary>
    [JsonPropertyName("phone_numbers")]
    public required IReadOnlyList<BusinessPhoneNumber> PhoneNumbers { get; init; }

    /// <summary>
    /// Email addresses associated with the business
    /// </summary>
    [JsonPropertyName("email_addresses")]
    public required IReadOnlyList<BusinessEmailAddress> EmailAddresses { get; init; }

    /// <summary>
    /// Websites associated with the business
    /// </summary>
    [JsonPropertyName("websites")]
    public required IReadOnlyList<BusinessWebsite> Websites { get; init; }

    /// <summary>
    /// A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).
    /// </summary>
    [JsonPropertyName("formation_date")]
    public required DateTimeOffset? FormationDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
