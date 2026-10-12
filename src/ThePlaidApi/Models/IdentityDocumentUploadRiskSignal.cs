using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Risk signals tied to the document
/// </summary>
public record IdentityDocumentUploadRiskSignal
{
    /// <summary>
    /// The type of risk found.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// Indicates whether fraud risk was detected for this risk signal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("has_fraud_risk")]
    public bool? HasFraudRisk { get; init; }

    /// <summary>
    /// A human-readable explanation providing more detail about the specific risk signal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signal_description")]
    public string? SignalDescription { get; init; }

    /// <summary>
    /// The relevant page associated with the risk signal. If the risk signal is not associated with a specific page, the value will be 0.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("page_number")]
    public int? PageNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
