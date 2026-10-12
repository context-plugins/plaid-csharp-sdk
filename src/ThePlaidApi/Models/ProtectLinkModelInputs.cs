using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Inputs for link session Trust Index models.
/// </summary>
public record ProtectLinkModelInputs
{
    /// <summary>
    /// A unique identifier for the Link session, used to compute a Trust Index score and fraud attributes.
    /// </summary>
    [JsonPropertyName("link_session_id")]
    [MaxLength(128)]
    public required string LinkSessionId { get; init; }

    /// <summary>
    /// Controls whether transaction extraction must be complete before scoring. If <c>false</c> (default), returns a score whether or not transaction extraction is complete, as long as the link session is finished; if data has been extracted it will still be included in the score computation. If <c>true</c>, returns HTTP 400 with <c>error_type</c> = <c>INVALID_REQUEST</c> and <c>error_code</c> = <c>FAILED_PRECONDITION</c> if extraction is still in progress; once data is ready a score will be returned normally.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("require_extracted_data")]
    public bool? RequireExtractedData { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
