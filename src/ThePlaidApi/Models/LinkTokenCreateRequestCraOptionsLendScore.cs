using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for initializing Link for use with the CRA LendScore product.
/// </summary>
public record LinkTokenCreateRequestCraOptionsLendScore
{
    /// <summary>
    /// The version of the LendScore to use. Required if using LendScore.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lend_score_version")]
    public PlaidLendScoreVersion? LendScoreVersion { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
