using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Details about the fraud analysis performed on the document.
/// </summary>
public record FraudAnalysisDetails
{
    /// <summary>
    /// Whether the submitted document type is supported for fraud analysis.
    /// <para>
    /// <c>success</c> - The document type is supported.
    /// </para>
    /// <para>
    /// <c>failed</c> - The document type is not supported.
    /// </para>
    /// </summary>
    [JsonPropertyName("type_supported")]
    public required FraudCheckOutcome TypeSupported { get; init; }

    /// <summary>
    /// The outcome of the portrait presence check.
    /// <para>
    /// <c>success</c> - A portrait was detected.
    /// </para>
    /// <para>
    /// <c>failed</c> - No portrait was detected.
    /// </para>
    /// </summary>
    [JsonPropertyName("portrait_presence_check")]
    public required FraudCheckOutcome PortraitPresenceCheck { get; init; }

    /// <summary>
    /// The outcome of the portrait details check including photo embedding and face landmark checks.
    /// <para>
    /// <c>success</c> - The portrait passed all validity checks.
    /// </para>
    /// <para>
    /// <c>failed</c> - The portrait did not pass one or more validity checks.
    /// </para>
    /// </summary>
    [JsonPropertyName("portrait_details_check")]
    public required FraudCheckOutcome PortraitDetailsCheck { get; init; }

    /// <summary>
    /// The outcome of the image composition check.
    /// <para>
    /// <c>success</c> - The image is a valid physical document capture.
    /// </para>
    /// <para>
    /// <c>failed</c> - The image appears to be a photograph of a screen or a digital forgery.
    /// </para>
    /// </summary>
    [JsonPropertyName("image_composition_check")]
    public required FraudCheckOutcome ImageCompositionCheck { get; init; }

    /// <summary>
    /// The outcome of the integrity check for document security elements.
    /// <para>
    /// <c>success</c> - Data is consistent across all checked security elements.
    /// </para>
    /// <para>
    /// <c>failed</c> - Inconsistencies were detected across one or more security elements.
    /// </para>
    /// </summary>
    [JsonPropertyName("integrity_check")]
    public required FraudCheckOutcome IntegrityCheck { get; init; }

    /// <summary>
    /// The outcome of the document detail check for correct styling and layout.
    /// <para>
    /// <c>success</c> - The document passed all authenticity checks.
    /// </para>
    /// <para>
    /// <c>failed</c> - The document did not pass one or more authenticity checks.
    /// </para>
    /// </summary>
    [JsonPropertyName("detail_check")]
    public required FraudCheckOutcome DetailCheck { get; init; }

    /// <summary>
    /// The outcome of the issue date validity check.
    /// <para>
    /// <c>success</c> - The issue date is valid.
    /// </para>
    /// <para>
    /// <c>failed</c> - The issue date is invalid or could not be verified.
    /// </para>
    /// <para>
    /// <c>no_data</c> - The check could not be performed due to insufficient data.
    /// </para>
    /// </summary>
    [JsonPropertyName("issue_date_check")]
    public required FraudCheckOutcomeWithNoData IssueDateCheck { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
