using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Details about a certain reason as to why a document could potentially be fraudulent.
/// </summary>
public record DocumentRiskSignal
{
    /// <summary>
    /// The type of risk found in the risk signal check.
    /// </summary>
    [JsonPropertyName("type")]
    public required string? Type { get; init; }

    /// <summary>
    /// The field which the risk signal was computed for
    /// </summary>
    [JsonPropertyName("field")]
    public required string? Field { get; init; }

    /// <summary>
    /// A flag used to quickly identify if the signal indicates that this field is authentic or fraudulent
    /// </summary>
    [JsonPropertyName("has_fraud_risk")]
    public required bool? HasFraudRisk { get; init; }

    /// <summary>
    /// An object which contains additional metadata about the institution used to compute the verification attribute
    /// </summary>
    [JsonPropertyName("institution_metadata")]
    public required DocumentRiskSignalInstitutionMetadata? InstitutionMetadata { get; init; }

    /// <summary>
    /// The expected value of the field, as seen on the document
    /// </summary>
    [JsonPropertyName("expected_value")]
    public required string? ExpectedValue { get; init; }

    /// <summary>
    /// The derived value obtained in the risk signal calculation process for this field
    /// </summary>
    [JsonPropertyName("actual_value")]
    public required string? ActualValue { get; init; }

    /// <summary>
    /// A human-readable explanation providing more detail into the particular risk signal
    /// </summary>
    [JsonPropertyName("signal_description")]
    public required string? SignalDescription { get; init; }

    /// <summary>
    /// The relevant page associated with the risk signal. If the risk signal is not associated with a specific page, the value will be 0.
    /// </summary>
    [JsonPropertyName("page_number")]
    public required int? PageNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
