using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// ItemImportRequest defines the request schema for <c>/item/import</c>
/// </summary>
public record ItemImportRequest
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
    /// The Plaid Institution ID associated with the Item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_id")]
    public string? InstitutionId { get; init; }

    /// <summary>
    /// Array of product strings
    /// </summary>
    [JsonPropertyName("products")]
    [MinLength(1)]
    public required IReadOnlyList<Products> Products { get; init; }

    /// <summary>
    /// Object of user ID and auth token pair, permitting Plaid to aggregate a user's accounts
    /// </summary>
    [JsonPropertyName("user_auth")]
    public required ItemImportRequestUserAuth UserAuth { get; init; }

    /// <summary>
    /// An optional object to configure <c>/item/import</c> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public ItemImportRequestOptions? Options { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
