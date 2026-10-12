using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A program that configures the active lists, search parameters, and other behavior for initial and ongoing screening of entities.
/// </summary>
public record EntityWatchlistProgram
{
    /// <summary>
    /// ID of the associated entity program.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Indicator specifying whether the program is enabled and will perform daily rescans.
    /// </summary>
    [JsonPropertyName("is_rescanning_enabled")]
    public required bool IsRescanningEnabled { get; init; }

    /// <summary>
    /// Watchlists enabled for the associated program
    /// </summary>
    [JsonPropertyName("lists_enabled")]
    [UniqueItems]
    public required IReadOnlyList<EntityWatchlistCode> ListsEnabled { get; init; }

    /// <summary>
    /// A name for the entity program to define its purpose. For example, "High Risk Organizations" or "Applicants".
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The valid name matching sensitivity configurations for a screening program. Note that while certain matching techniques may be more prevalent on less strict settings, all matching algorithms are enabled for every sensitivity.
    /// <para>
    /// <c>coarse</c> - See more potential matches. This sensitivity will see more broad phonetic matches across alphabets that make missing a potential hit very unlikely. This setting is noisier and will require more manual review.
    /// </para>
    /// <para>
    /// <c>balanced</c> - A good default for most companies. This sensitivity is balanced to show high quality hits with reduced noise.
    /// </para>
    /// <para>
    /// <c>strict</c> - Aggressive false positive reduction. This sensitivity will require names to be more similar than <c>coarse</c> and <c>balanced</c> settings, relying less on phonetics, while still accounting for character transpositions, missing tokens, and other common permutations.
    /// </para>
    /// <para>
    /// <c>exact</c> - Matches must be nearly exact. This sensitivity will only show hits with exact or nearly exact name matches with only basic correction such as extraneous symbols and capitalization. This setting is generally not recommended unless you have a very specific use case.
    /// </para>
    /// </summary>
    [JsonPropertyName("name_sensitivity")]
    public required ProgramNameSensitivity NameSensitivity { get; init; }

    /// <summary>
    /// Information about the last change made to the parent object specifying what caused the change as well as when it occurred.
    /// </summary>
    [JsonPropertyName("audit_trail")]
    public required WatchlistScreeningAuditTrail AuditTrail { get; init; }

    /// <summary>
    /// Archived programs are read-only and cannot screen new customers nor participate in ongoing monitoring.
    /// </summary>
    [JsonPropertyName("is_archived")]
    public required bool IsArchived { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
