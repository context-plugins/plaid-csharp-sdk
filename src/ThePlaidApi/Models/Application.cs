using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Metadata about the application
/// </summary>
public record Application
{
    /// <summary>
    /// This field will map to the application ID that is returned from <c>/item/application/list</c>, or provided to the institution in an oauth redirect.
    /// </summary>
    [JsonPropertyName("application_id")]
    public required string ApplicationId { get; init; }

    /// <summary>
    /// The name of the application
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// A human-readable name of the application for display purposes
    /// </summary>
    [JsonPropertyName("display_name")]
    public required string? DisplayName { get; init; }

    /// <summary>
    /// The date this application was granted production access at Plaid in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> (YYYY-MM-DD) format in UTC.
    /// </summary>
    [JsonPropertyName("join_date")]
    public required DateTimeOffset JoinDate { get; init; }

    /// <summary>
    /// A URL that links to the application logo image.
    /// </summary>
    [JsonPropertyName("logo_url")]
    public required string? LogoUrl { get; init; }

    /// <summary>
    /// The URL for the application's website
    /// </summary>
    [JsonPropertyName("application_url")]
    public required string? ApplicationUrl { get; init; }

    /// <summary>
    /// A string provided by the connected app stating why they use their respective enabled products.
    /// </summary>
    [JsonPropertyName("reason_for_access")]
    public required string? ReasonForAccess { get; init; }

    /// <summary>
    /// A string representing client's broad use case as assessed by Plaid.
    /// </summary>
    [JsonPropertyName("use_case")]
    public required string? UseCase { get; init; }

    /// <summary>
    /// A string representing the name of client's legal entity.
    /// </summary>
    [JsonPropertyName("company_legal_name")]
    public required string? CompanyLegalName { get; init; }

    /// <summary>
    /// A string representing the city of the client's headquarters.
    /// </summary>
    [JsonPropertyName("city")]
    public required string? City { get; init; }

    /// <summary>
    /// A string representing the region of the client's headquarters.
    /// </summary>
    [JsonPropertyName("region")]
    public required string? Region { get; init; }

    /// <summary>
    /// A string representing the postal code of the client's headquarters.
    /// </summary>
    [JsonPropertyName("postal_code")]
    public required string? PostalCode { get; init; }

    /// <summary>
    /// A string representing the country code of the client's headquarters.
    /// </summary>
    [JsonPropertyName("country_code")]
    public required string? CountryCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
