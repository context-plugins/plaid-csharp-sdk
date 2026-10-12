using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Details about the human review check, which refers to a check that is performed by a document specialist.
/// </summary>
public record HumanReview
{
    /// <summary>
    /// The outcome of the human review check, when available. The following values are possible:
    /// <para>
    ///
    /// <c>success</c> - The document passed the check.
    /// </para>
    /// <para>
    /// <c>failed</c> - The document failed the check.
    /// </para>
    /// <para>
    /// <c>no_data</c> - The document was submitted, but the document specialist review was not completed in time.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required HumanReviewStatus Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
