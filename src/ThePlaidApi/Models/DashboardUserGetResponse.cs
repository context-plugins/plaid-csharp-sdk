using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Account information associated with a team member with access to the Plaid dashboard.
/// </summary>
public record DashboardUserGetResponse
{
    /// <summary>
    /// ID of the associated user. To retrieve the email address or other details of the person corresponding to this ID, use <c>/dashboard_user/get</c>.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// A valid email address. Must not have leading or trailing spaces and address must be RFC compliant. For more information, see <see href="https://datatracker.ietf.org/doc/html/rfc3696">RFC 3696</see>.
    /// </summary>
    [JsonPropertyName("email_address")]
    [Format(FormatKind.Email)]
    public required string EmailAddress { get; init; }

    /// <summary>
    /// The current status of the user.
    /// </summary>
    [JsonPropertyName("status")]
    public required DashboardUserStatus Status { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
