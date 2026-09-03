using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A Beacon Report Syndication represents a Beacon Report created either by your organization or another Beacon customer that matches a specific Beacon User you've created.
/// <para>
/// The <c>analysis</c> field in the response indicates which fields matched between the originally reported Beacon User and the Beacon User that the report was syndicated to.
/// </para>
/// <para>
/// The <c>report</c> field in the response contains a subset of information from the original report.
/// </para>
/// </summary>
public record BeaconReportSyndication
{
    /// <summary>
    /// ID of the associated Beacon Report Syndication.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// ID of the associated Beacon User.
    /// </summary>
    [JsonPropertyName("beacon_user_id")]
    public required string BeaconUserId { get; init; }

    /// <summary>
    /// A subset of information from a Beacon Report that has been syndicated to a matching Beacon User in your program.
    /// <para>
    /// The <c>id</c> field in the response is the ID of the original report that was syndicated. If the original report was created by your organization, the field will be filled with the ID of the report. Otherwise, the field will be <c>null</c> indicating that the original report was created by another Beacon customer.
    /// </para>
    /// </summary>
    [JsonPropertyName("report")]
    public required BeaconReportSyndicationOriginalReport Report { get; init; }

    /// <summary>
    /// Analysis of which fields matched between the originally reported Beacon User and the Beacon User that the report was syndicated to.
    /// </summary>
    [JsonPropertyName("analysis")]
    public required BeaconReportSyndicationAnalysis Analysis { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
