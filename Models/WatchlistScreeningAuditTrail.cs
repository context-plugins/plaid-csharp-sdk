using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Information about the last change made to the parent object specifying what caused the change as well as when it occurred.
/// </summary>
public record WatchlistScreeningAuditTrail
{
    /// <summary>
    /// A type indicating who or what last touched this object. <c>dashboard</c>, <c>link</c>, and <c>api</c> indicate the originating surface; <c>system</c> indicates Plaid. <c>retro</c> indicates a screening created retroactively via a bulk screening creation.
    /// </summary>
    [JsonPropertyName("source")]
    public required Source Source { get; init; }

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
