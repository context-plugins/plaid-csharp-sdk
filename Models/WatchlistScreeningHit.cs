using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Data from a government watchlist or PEP list that has been attached to the screening.
/// </summary>
public record WatchlistScreeningHit
{
    /// <summary>
    /// ID of the associated screening hit.
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
    /// Shorthand identifier for a specific screening list for individuals.
    ///  <c>AU_CON</c>: Australia Department of Foreign Affairs and Trade Consolidated List
    ///  <c>CA_CON</c>: Government of Canada Consolidated List of Sanctions
    ///  <c>EU_CON</c>: European External Action Service Consolidated List
    ///  <c>IZ_CIA</c>: CIA List of Chiefs of State and Cabinet Members
    ///  <c>IZ_IPL</c>: Interpol Red Notices for Wanted Persons List
    ///  <c>IZ_PEP</c>: Politically Exposed Persons List
    ///  <c>IZ_UNC</c>: United Nations Consolidated Sanctions
    ///  <c>IZ_WBK</c>: World Bank Listing of Ineligible Firms and Individuals
    ///  <c>UK_HMC</c>: Foreign, Commonwealth &amp; Development Office UK Sanctions List
    ///  <c>US_DPL</c>: Bureau of Industry and Security Denied Persons List
    ///  <c>US_DTC</c>: US Department of State AECA Debarred
    ///  <c>US_FBI</c>: US Department of Justice FBI Wanted List
    ///  <c>US_FSE</c>: US OFAC Foreign Sanctions Evaders
    ///  <c>US_ISN</c>: US Department of State Nonproliferation Sanctions
    ///  <c>US_MBS</c>: US Non-SDN Menu-Based Sanctions
    ///  <c>US_PLC</c>: US OFAC Palestinian Legislative Council
    ///  <c>US_SAM</c>: US System for Award Management Exclusion List
    ///  <c>US_SDN</c>: US OFAC Specially Designated Nationals List
    ///  <c>US_SSI</c>: US OFAC Sectoral Sanctions Identifications
    ///  <c>SG_SOF</c>: Government of Singapore Terrorists and Terrorist Entities
    ///  <c>TR_TWL</c>: Government of Turkey Terrorist Wanted List
    ///  <c>TR_DFD</c>: Government of Turkey Domestic Freezing Decisions
    ///  <c>TR_FOR</c>: Government of Turkey Foreign Freezing Requests
    ///  <c>TR_WMD</c>: Government of Turkey Weapons of Mass Destruction
    ///  <c>TR_CMB</c>: Government of Turkey Capital Markets Board
    /// </summary>
    [JsonPropertyName("list_code")]
    public required IndividualWatchlistCode ListCode { get; init; }

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
    /// Analysis information describing why a screening hit matched the provided user information
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("analysis")]
    public ScreeningHitAnalysis? Analysis { get; init; }

    /// <summary>
    /// Information associated with the watchlist hit
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public ScreeningHitData? Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
