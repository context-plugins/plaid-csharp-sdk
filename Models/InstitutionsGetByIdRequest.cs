using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// InstitutionsGetByIdRequest defines the request schema for <c>/institutions/get_by_id</c>
/// </summary>
public record InstitutionsGetByIdRequest
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
    /// The ID of the institution to get details about
    /// </summary>
    [JsonPropertyName("institution_id")]
    [MinLength(1)]
    public required string InstitutionId { get; init; }

    /// <summary>
    /// Specify which country or countries to include institutions from, using the ISO-3166-1 alpha-2 country code standard. In API versions 2019-05-29 and earlier, the <c>country_codes</c> parameter is an optional parameter within the <c>options</c> object and will default to <c>[US]</c> if it is not supplied.
    /// </summary>
    [JsonPropertyName("country_codes")]
    public required IReadOnlyList<CountryCode> CountryCodes { get; init; }

    /// <summary>
    /// Specifies optional parameters for <c>/institutions/get_by_id</c>. If provided, must not be <c>null</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public InstitutionsGetByIdRequestOptions? Options { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
