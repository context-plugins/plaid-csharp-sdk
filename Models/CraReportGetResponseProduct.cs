using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Per-product report data. <c>attributes</c> is an opaque map of key-value pairs; for a full list of attributes per product and version, see the data dictionary.
/// </summary>
public record CraReportGetResponseProduct
{
    [JsonPropertyName("product")]
    public required Products Product { get; init; }

    /// <summary>
    /// The version of the product that was generated.
    /// </summary>
    [JsonPropertyName("version")]
    public required string Version { get; init; }

    /// <summary>
    /// A map of product report metadata, where the key is a string and the value varies by product. For a full list of metadata fields per product, see the data dictionary. May be <c>null</c> if metadata was not available.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required IReadOnlyDictionary<string, object?> Metadata { get; init; }

    /// <summary>
    /// A map of product attributes, where the key is a string and the value can be any JSON value. The specific list of attributes depends on the product and version. For a full list, see the data dictionary. May be <c>null</c> if attributes were not available.
    /// </summary>
    [JsonPropertyName("attributes")]
    public required IReadOnlyDictionary<string, object?> Attributes { get; init; }

    /// <summary>
    /// Product-level errors. Non-empty when this product failed to generate; empty on success.
    /// </summary>
    [JsonPropertyName("errors")]
    public required IReadOnlyList<Error> Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
