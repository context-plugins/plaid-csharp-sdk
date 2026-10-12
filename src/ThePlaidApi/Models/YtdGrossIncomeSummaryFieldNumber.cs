using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Year-to-date pre-tax earnings, as reported on the paystub.
/// </summary>
public record YtdGrossIncomeSummaryFieldNumber
{
    /// <summary>
    /// The value of the field.
    /// </summary>
    [JsonPropertyName("value")]
    public required double Value { get; init; }

    /// <summary>
    /// The verification status. One of the following:
    /// <para>
    /// <c>"VERIFIED"</c>: The information was successfully verified.
    /// </para>
    /// <para>
    /// <c>"UNVERIFIED"</c>: The verification has not yet been performed.
    /// </para>
    /// <para>
    /// <c>"NEEDS_INFO"</c>: The verification was attempted but could not be completed due to missing information.
    /// </para>
    /// <para>
    /// "<c>UNABLE_TO_VERIFY</c>": The verification was performed and the information could not be verified.
    /// </para>
    /// <para>
    /// <c>"UNKNOWN"</c>: The verification status is unknown.
    /// </para>
    /// </summary>
    [JsonPropertyName("verification_status")]
    public required VerificationStatus VerificationStatus { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
