using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// CraCreditProfileReportGetResponse defines the response schema for <c>/cra/credit_profile/report/get</c>.
/// </summary>
public record CraCreditProfileReportGetResponse
{
    /// <summary>
    /// Contains data for the CRA Credit Profile Report.
    /// </summary>
    [JsonPropertyName("report")]
    public required CraCreditProfileReport Report { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <see href="https://plaid.com/docs/api/users/user-apis">New User APIs</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }

    /// <summary>
    /// If the report generation was successful but a subset of data could not be retrieved, this array will contain information about the errors causing information to be missing
    /// </summary>
    [JsonPropertyName("warnings")]
    public required IReadOnlyList<CraReportWarning> Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
