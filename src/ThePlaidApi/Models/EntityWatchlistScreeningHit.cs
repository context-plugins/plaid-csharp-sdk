using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Data from a government watchlist that has been attached to the screening.
/// </summary>
public record EntityWatchlistScreeningHit
{
    /// <summary>
    /// ID of the associated entity screening hit.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The current state of review. All watchlist screening hits begin in a <c>pending_review</c> state but can be changed by creating a review. When a hit is in the <c>pending_review</c> state, it will always show the latest version of the watchlist data Plaid has available and be compared against the latest customer information saved in the watchlist screening. Once a hit has been marked as <c>confirmed</c> or <c>dismissed</c> it will no longer be updated so that the state is as it was when the review was first conducted.
    /// </summary>
    [JsonPropertyName("review_status")]
    public required WatchlistScreeningHitStatus ReviewStatus { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("first_active")]
    public required DateTimeOffset FirstActive { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("inactive_since")]
    public required DateTimeOffset? InactiveSince { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("historical_since")]
    public required DateTimeOffset? HistoricalSince { get; init; }

    /// <summary>
    /// Shorthand identifier for a specific screening list for entities.
    ///  <c>AU_CON</c>: Australia Department of Foreign Affairs and Trade Consolidated List
    ///  <c>CA_CON</c>: Government of Canada Consolidated List of Sanctions
    ///  <c>EU_CON</c>: European External Action Service Consolidated List
    ///  <c>IZ_SOE</c>: State Owned Enterprise List
    ///  <c>IZ_UNC</c>: United Nations Consolidated Sanctions
    ///  <c>IZ_WBK</c>: World Bank Listing of Ineligible Firms and Individuals
    ///  <c>US_CAP</c>: US OFAC Correspondent Account or Payable-Through Account Sanctions
    ///  <c>US_FSE</c>: US OFAC Foreign Sanctions Evaders
    ///  <c>US_MBS</c>: US Non-SDN Menu-Based Sanctions
    ///  <c>US_SDN</c>: US OFAC Specially Designated Nationals List
    ///  <c>US_SSI</c>: US OFAC Sectoral Sanctions Identifications
    ///  <c>US_CMC</c>: US OFAC Non-SDN Chinese Military-Industrial Complex List
    ///  <c>US_UVL</c>: Bureau of Industry and Security Unverified List
    ///  <c>US_SAM</c>: US System for Award Management Exclusion List
    ///  <c>US_TEL</c>: US Terrorist Exclusion List
    ///  <c>UK_HMC</c>: Foreign, Commonwealth &amp; Development Office UK Sanctions List
    /// </summary>
    [JsonPropertyName("list_code")]
    public required EntityWatchlistCode ListCode { get; init; }

    /// <summary>
    /// A universal identifier for a watchlist individual that is stable across searches and updates.
    /// </summary>
    [JsonPropertyName("plaid_uid")]
    public required string PlaidUid { get; init; }

    /// <summary>
    /// The identifier provided by the source sanction or watchlist. When one is not provided by the source, this is <c>null</c>.
    /// </summary>
    [JsonPropertyName("source_uid")]
    public required string? SourceUid { get; init; }

    /// <summary>
    /// Sub-program designations that may be attached to the watchlist entry by the issuing authority. For OFAC SDN
    /// entries these are the program codes published in the SDN list (for example <c>SDGT</c> for Specially
    /// Designated Global Terrorists, <c>SDNTK</c> for Specially Designated Narcotics Trafficking Kingpins,
    /// <c>IRAN</c>, <c>RUSSIA-EO14024</c>). New codes are added by sanctioning authorities without prior notice,
    /// so callers should treat unknown values as opaque strings rather than enum members.
    /// </summary>
    [JsonPropertyName("sub_programs")]
    public required IReadOnlyList<string> SubPrograms { get; init; }

    /// <summary>
    /// Analysis information describing why a screening hit matched the provided entity information
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("analysis")]
    public EntityScreeningHitAnalysis? Analysis { get; init; }

    /// <summary>
    /// Information associated with the entity watchlist hit
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public EntityScreeningHitData? Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
