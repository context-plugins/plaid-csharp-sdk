using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A subset of information from a Beacon Report that has been syndicated to a matching Beacon User in your program.
/// <para>
/// The <c>id</c> field in the response is the ID of the original report that was syndicated. If the original report was created by your organization, the field will be filled with the ID of the report. Otherwise, the field will be <c>null</c> indicating that the original report was created by another Beacon customer.
/// </para>
/// </summary>
public record BeaconReportSyndicationOriginalReport
{
    /// <summary>
    /// ID of the associated Beacon Report.
    /// </summary>
    [JsonPropertyName("id")]
    public required string? Id { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// The type of Beacon Report.
    /// <para>
    /// <c>first_party</c>: If this is the same individual as the one who submitted the KYC.
    /// </para>
    /// <para>
    /// <c>stolen</c>: If this is a different individual from the one who submitted the KYC.
    /// </para>
    /// <para>
    /// <c>synthetic</c>: If this is an individual using fabricated information.
    /// </para>
    /// <para>
    /// <c>account_takeover</c>: If this individual's account was compromised.
    /// </para>
    /// <para>
    /// <c>data_breach</c>: If this individual's data was compromised in a breach.
    /// </para>
    /// <para>
    /// <c>unknown</c>: If you aren't sure who committed the fraud.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required BeaconReportType Type { get; init; }

    /// <summary>
    /// A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).
    /// </summary>
    [JsonPropertyName("fraud_date")]
    public required DateTimeOffset? FraudDate { get; init; }

    /// <summary>
    /// A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).
    /// </summary>
    [JsonPropertyName("event_date")]
    public required DateTimeOffset EventDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
