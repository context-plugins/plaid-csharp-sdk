using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// CraReportGetResponse defines the response schema for <c>/cra/report/get</c>.
/// </summary>
public record CraReportGetResponse
{
    /// <summary>
    /// The CRA report returned by <c>/cra/report/get</c>.
    /// </summary>
    [JsonPropertyName("report")]
    public required CraReportGetReport Report { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <see href="https://plaid.com/docs/api/users/user-apis">New User APIs</see>.
    /// </summary>
    [JsonPropertyName("user_id")]
    public required string UserId { get; init; }

    /// <summary>
    /// User or report-level errors that affected the overall report but do not map to a specific product failure.
    /// </summary>
    [JsonPropertyName("warnings")]
    public required IReadOnlyList<CraReportWarning> Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
