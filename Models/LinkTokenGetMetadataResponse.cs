using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An object specifying the arguments originally provided to the <c>/link/token/create</c> call.
/// </summary>
public record LinkTokenGetMetadataResponse
{
    /// <summary>
    /// The <c>products</c> specified in the <c>/link/token/create</c> call.
    /// </summary>
    [JsonPropertyName("initial_products")]
    public required IReadOnlyList<Products> InitialProducts { get; init; }

    /// <summary>
    /// The <c>webhook</c> specified in the <c>/link/token/create</c> call.
    /// </summary>
    [JsonPropertyName("webhook")]
    public required string? Webhook { get; init; }

    /// <summary>
    /// The <c>country_codes</c> specified in the <c>/link/token/create</c> call.
    /// </summary>
    [JsonPropertyName("country_codes")]
    public required IReadOnlyList<CountryCode> CountryCodes { get; init; }

    /// <summary>
    /// The <c>language</c> specified in the <c>/link/token/create</c> call.
    /// </summary>
    [JsonPropertyName("language")]
    public required string? Language { get; init; }

    /// <summary>
    /// A map containing data used to highlight institutions in Link.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_data")]
    public LinkTokenCreateInstitutionData? InstitutionData { get; init; }

    /// <summary>
    /// The <c>account_filters</c> specified in the original call to <c>/link/token/create</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_filters")]
    public AccountFiltersResponse? AccountFilters { get; init; }

    /// <summary>
    /// The <c>redirect_uri</c> specified in the <c>/link/token/create</c> call.
    /// </summary>
    [JsonPropertyName("redirect_uri")]
    public required string? RedirectUri { get; init; }

    /// <summary>
    /// The <c>client_name</c> specified in the <c>/link/token/create</c> call.
    /// </summary>
    [JsonPropertyName("client_name")]
    public required string? ClientName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
