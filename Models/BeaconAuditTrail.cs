using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Information about the last change made to the parent object specifying what caused the change as well as when it occurred.
/// </summary>
public record BeaconAuditTrail
{
    /// <summary>
    /// A type indicating what caused a resource to be changed or updated.
    /// <para>
    ///
    /// <c>dashboard</c> - The resource was created or updated by a member of your team via the Plaid dashboard.
    /// </para>
    /// <para>
    /// <c>api</c> - The resource was created or updated via the Plaid API.
    /// </para>
    /// <para>
    /// <c>system</c> - The resource was created or updated automatically by a part of the Plaid Beacon system. For example, if another business using Plaid Beacon created a fraud report that matched one of your users, your matching user's status would automatically be updated and the audit trail source would be <c>system</c>.
    /// </para>
    /// <para>
    /// <c>bulk_import</c> - The resource was created or updated as part of a bulk import process. For example, if your company provided a CSV of user data as part of your initial onboarding, the audit trail source would be <c>bulk_import</c>.
    /// </para>
    /// </summary>
    [JsonPropertyName("source")]
    public required BeaconAuditTrailSource Source { get; init; }

    /// <summary>
    /// ID of the associated user. To retrieve the email address or other details of the person corresponding to this ID, use <c>/dashboard_user/get</c>.
    /// </summary>
    [JsonPropertyName("dashboard_user_id")]
    public required string? DashboardUserId { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public required DateTimeOffset Timestamp { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
