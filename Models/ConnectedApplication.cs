using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Describes the connected application for a particular end user.
/// </summary>
public record ConnectedApplication
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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("display_name")]
    public string? DisplayName { get; init; }

    /// <summary>
    /// A URL that links to the application logo image.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logo_url")]
    public string? LogoUrl { get; init; }

    /// <summary>
    /// The URL for the application's website
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("application_url")]
    public string? ApplicationUrl { get; init; }

    /// <summary>
    /// A string provided by the connected app stating why they use their respective enabled products.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason_for_access")]
    public string? ReasonForAccess { get; init; }

    /// <summary>
    /// The date and time this application was linked, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format in UTC (e.g. <c>"2020-01-01T00:00:00Z"</c>). Note that older, legacy integrations instead receive this value as a date only, in <c>YYYY-MM-DD</c> format (e.g. <c>"2020-01-01"</c>).
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// The scopes object
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scopes")]
    public ScopesNullable? Scopes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
