using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Age-estimation results from the selfie capture. This field is <c>null</c> when an age range could not be estimated from the selfie capture.
/// </summary>
public record SelfieAgeCheck
{
    /// <summary>
    /// An enum indicating whether the reported age aligns with the estimated selfie capture age range.
    /// <para>
    /// <c>match</c> indicates that the reported age falls within the estimated selfie capture age range.
    /// </para>
    /// <para>
    /// <c>warning</c> indicates that the reported age falls outside the estimated selfie capture age range, but is close enough that the result should be reviewed.
    /// </para>
    /// <para>
    /// <c>no_match</c> indicates that the reported age falls far outside the estimated selfie capture age range.
    /// </para>
    /// <para>
    /// <c>no_data</c> indicates that there was not enough data available at age-estimation time to compare the reported age against the estimated selfie capture age range.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required SelfieAgeCheckStatus Status { get; init; }

    /// <summary>
    /// The user's age at the time of the selfie capture, calculated from the date of birth submitted during Identity Verification. If multiple date of birth sources are available, the date of birth submitted in the flow session takes priority over the document date of birth. This field is <c>null</c> when the date of birth is unavailable.
    /// </summary>
    [JsonPropertyName("reported_age")]
    public required int? ReportedAge { get; init; }

    /// <summary>
    /// Lower bound of the estimated age range from the selfie capture.
    /// </summary>
    [JsonPropertyName("age_estimate_lower_bound")]
    public required int AgeEstimateLowerBound { get; init; }

    /// <summary>
    /// Upper bound of the estimated age range from the selfie capture.
    /// </summary>
    [JsonPropertyName("age_estimate_upper_bound")]
    public required int AgeEstimateUpperBound { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
