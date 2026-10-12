using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Paginated list of dashboard users
/// </summary>
public record DashboardUserListResponse
{
    /// <summary>
    /// List of dashboard users
    /// </summary>
    [JsonPropertyName("dashboard_users")]
    public required IReadOnlyList<DashboardUser> DashboardUsers { get; init; }

    /// <summary>
    /// An identifier that determines which page of results you receive.
    /// </summary>
    [JsonPropertyName("next_cursor")]
    public required string? NextCursor { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
