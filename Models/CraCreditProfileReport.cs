using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Contains data for the CRA Credit Profile Report.
/// </summary>
public record CraCreditProfileReport
{
    /// <summary>
    /// The time when the report was retrieved.
    /// </summary>
    [JsonPropertyName("date_retrieved")]
    public required DateTimeOffset DateRetrieved { get; init; }

    /// <summary>
    /// The inquiry type of credit profile report.
    /// </summary>
    [JsonPropertyName("inquiry_type")]
    public required CraCreditProfileInquiryType InquiryType { get; init; }

    /// <summary>
    /// Client-generated identifier, which can be used by lenders to track loan applications.
    /// </summary>
    [JsonPropertyName("client_report_id")]
    public required string ClientReportId { get; init; }

    /// <summary>
    /// The LendScore results for the credit profile report.
    /// </summary>
    [JsonPropertyName("lend_scores")]
    public required IReadOnlyList<CraCreditProfileLendScore> LendScores { get; init; }

    /// <summary>
    /// A map of cash flow attributes, where the key is a string, and the value is a string, float, int, or boolean. The specific list of attributes will depend on the cash flow attributes version used. For a full list of attributes, contact your account manager.
    /// </summary>
    [JsonPropertyName("cashflow_insights_attributes")]
    public required IReadOnlyDictionary<string, object?> CashflowInsightsAttributes { get; init; }

    /// <summary>
    /// A map of network attributes, where the key is a string, and the value is a float, int, or boolean. For a full list of attributes, contact your account manager.
    /// </summary>
    [JsonPropertyName("network_insights_attributes")]
    public required IReadOnlyDictionary<string, object?> NetworkInsightsAttributes { get; init; }

    /// <summary>
    /// Metadata about the CRA Credit Profile Report.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required CraCreditProfileReportMetadata? Metadata { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
