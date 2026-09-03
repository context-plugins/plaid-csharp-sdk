using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The data from the CashScore® product returned by Prism Data.
/// </summary>
public record PrismCashScore
{
    /// <summary>
    /// The version of Prism Data's cash score model used. This field is deprecated in favor of <c>model_version</c>.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; init; }

    /// <summary>
    /// The version of Prism Data's cash score model used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model_version")]
    public string? ModelVersion { get; init; }

    /// <summary>
    /// The score returned by Prism Data. Ranges from 1-999, with higher score indicating lower risk.
    /// </summary>
    [JsonPropertyName("score")]
    public required int? Score { get; init; }

    /// <summary>
    /// The reasons for an individual having risk according to the cash score.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason_codes")]
    public IReadOnlyList<string>? ReasonCodes { get; init; }

    /// <summary>
    /// An object containing metadata about the provided transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public PrismCashScoreMetadata? Metadata { get; init; }

    /// <summary>
    /// The error returned by Prism for this product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error_reason")]
    public string? ErrorReason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
