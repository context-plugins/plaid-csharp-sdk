using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Information about a report identifier and a report name.
/// </summary>
public record CreditFreddieMacReportingInformation
{
    /// <summary>
    /// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ReportDateTime")]
    public string? ReportDateTime { get; init; }

    /// <summary>
    /// Documentation not found in the MISMO model viewer and not provided by Freddie Mac. The value can only be "ReportID".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ReportIdentifierType")]
    public string? ReportIdentifierType { get; init; }

    /// <summary>
    /// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ReportingInformationParentIdentifier")]
    public string? ReportingInformationParentIdentifier { get; init; }

    /// <summary>
    /// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
    /// </summary>
    [JsonPropertyName("ReportingInformationIdentifier")]
    public required string ReportingInformationIdentifier { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
