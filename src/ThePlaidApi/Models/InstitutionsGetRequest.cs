using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// InstitutionsGetRequest defines the request schema for <c>/institutions/get</c>
/// </summary>
public record InstitutionsGetRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// The total number of Institutions to return.
    /// </summary>
    [JsonPropertyName("count")]
    [Minimum(1)]
    [Maximum(500)]
    public required int Count { get; init; }

    /// <summary>
    /// The number of Institutions to skip.
    /// </summary>
    [JsonPropertyName("offset")]
    [Minimum(0)]
    public required int Offset { get; init; }

    /// <summary>
    /// Specify which country or countries to include institutions from, using the ISO-3166-1 alpha-2 country code standard.
    /// <para>
    /// In API versions 2019-05-29 and earlier, the <c>country_codes</c> parameter is an optional parameter within the <c>options</c> object and will default to <c>[US]</c> if it is not supplied.
    /// </para>
    /// </summary>
    [JsonPropertyName("country_codes")]
    [MinLength(1)]
    public required IReadOnlyList<CountryCode> CountryCodes { get; init; }

    /// <summary>
    /// An optional object to filter <c>/institutions/get</c> results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public InstitutionsGetRequestOptions? Options { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
