using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// One permissioned resource on a consent grant.
/// </summary>
public record FdxConsentGrantResource
{
    /// <summary>
    /// Type of resource permissioned on a consent grant.
    /// </summary>
    [JsonPropertyName("resourceType")]
    public required FdxConsentResourceType ResourceType { get; init; }

    /// <summary>
    /// Identifier of the resource permissioned.
    /// </summary>
    [JsonPropertyName("resourceId")]
    public required string ResourceId { get; init; }

    /// <summary>
    /// Names of clusters of data elements permissioned.
    /// </summary>
    [JsonPropertyName("dataClusters")]
    public required IReadOnlyList<FdxDataCluster> DataClusters { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
