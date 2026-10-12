using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Details of consent or payment network identifier or other entity's revocation request or other lifecycle status change event
/// </summary>
public record FdxLifecycleEventEntity
{
    /// <summary>
    /// Current status of indicated entity after reported event change. Not all statuses will be supported on all entity types by all data providers
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public FdxEventStatus? Status { get; init; }

    /// <summary>
    /// Reason for lifecycle event status change
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public FdxUpdateReason? Reason { get; init; }

    /// <summary>
    /// Additional information or description of an <c>OTHER</c> reason
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("otherReason")]
    public string? OtherReason { get; init; }

    /// <summary>
    /// Identifies the type of a party
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("initiator")]
    public PartyType? Initiator { get; init; }

    /// <summary>
    /// ISO 8601 date-time in format 'YYYY-MM-DDThh:mm:ss.nnn[Z|[+|-]hh:mm]' according to <see href="https://datatracker.ietf.org/doc/html/rfc3339">IETF RFC3339</see>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updatedTime")]
    public DateTimeOffset? UpdatedTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
