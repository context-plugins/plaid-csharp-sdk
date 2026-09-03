using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// REST application constraint (Hypermedia As The Engine Of Application State)
/// </summary>
public record HateoasLink
{
    /// <summary>
    /// URL to invoke the action on the resource
    /// </summary>
    [JsonPropertyName("href")]
    [Format(FormatKind.UriReference)]
    public required string Href { get; init; }

    /// <summary>
    /// HTTP Method to use for the request
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("action")]
    public FdxHateoasLinkAction? Action { get; init; }

    /// <summary>
    /// Relation of this link to its containing entity, as defined by and with many example relation values at <see href="https://datatracker.ietf.org/doc/html/rfc5988">IETF RFC5988</see>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rel")]
    public string? Rel { get; init; }

    /// <summary>
    /// Content-types that can be used in the Accept header
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("types")]
    public IReadOnlyList<ContentTypes>? Types { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
