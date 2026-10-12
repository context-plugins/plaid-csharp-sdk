using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for initializing Link for use with the Base Report product. This field is required if <c>assets</c> is included in the <c>products</c> array and the client is CRA-enabled.
/// </summary>
public record LinkTokenCreateRequestBaseReport
{
    /// <summary>
    /// The maximum integer number of days of history to include in the Base Report.
    /// </summary>
    [JsonPropertyName("days_requested")]
    [Minimum(1)]
    [Maximum(730)]
    public required int DaysRequested { get; init; }

    /// <summary>
    /// Client-generated identifier, which can be used by lenders to track loan applications.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_report_id")]
    public string? ClientReportId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
