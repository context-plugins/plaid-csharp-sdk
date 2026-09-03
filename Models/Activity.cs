using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Describes a consent activity.
/// </summary>
public record Activity
{
    /// <summary>
    /// Types of consent activities
    /// </summary>
    [JsonPropertyName("activity")]
    public required ActivityType ActivityValue { get; init; }

    /// <summary>
    /// The date this activity was initiated <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> (YYYY-MM-DD) format in UTC.
    /// </summary>
    [JsonPropertyName("initiated_date")]
    public required DateTimeOffset InitiatedDate { get; init; }

    /// <summary>
    /// A unique identifier for the activity
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Application ID of the client who initiated the activity.
    /// </summary>
    [JsonPropertyName("initiator")]
    public required string Initiator { get; init; }

    /// <summary>
    /// Enum representing the state of the action/activity.
    /// </summary>
    [JsonPropertyName("state")]
    public required ActionState State { get; init; }

    /// <summary>
    /// This field will map to the application ID that is returned from <c>/item/application/list</c>, or provided to the institution in an oauth redirect.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("target_application_id")]
    public string? TargetApplicationId { get; init; }

    /// <summary>
    /// The scopes object
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scopes")]
    public ScopesNullable? Scopes { get; init; }

    /// <summary>
    /// Enum representing the entity authenticating the user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authentication")]
    public ItemCreateAuthentication? Authentication { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
