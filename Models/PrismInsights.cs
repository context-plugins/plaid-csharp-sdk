using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The data from the Insights product returned by Prism Data.
/// </summary>
public record PrismInsights
{
    /// <summary>
    /// The version of Prism Data's insights model used. This field is deprecated in favor of <c>model_version</c>.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; init; }

    /// <summary>
    /// The version of Prism Data's insights model used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model_version")]
    public string? ModelVersion { get; init; }

    /// <summary>
    /// The Insights Result object is a map of cash flow attributes, where the key is a string, and the value is a float or string. For a full list of attributes, contact your account manager. The attributes may vary depending on the Prism version used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("result")]
    public object? Result { get; init; }

    /// <summary>
    /// The error returned by Prism for this product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error_reason")]
    public string? ErrorReason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
