using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines consent payments limitations per period.
/// </summary>
public record PaymentConsentPeriodicAmount
{
    /// <summary>
    /// Maximum cumulative amount for all payments in the specified interval.
    /// </summary>
    [JsonPropertyName("amount")]
    public required PaymentAmount Amount { get; init; }

    /// <summary>
    /// Payment consent periodic interval.
    /// </summary>
    [JsonPropertyName("interval")]
    public required PaymentConsentPeriodicInterval Interval { get; init; }

    /// <summary>
    /// Where the payment consent period should start.
    /// <para>
    /// If the institution is Monzo, only <c>CONSENT</c> alignments are supported.
    /// </para>
    /// <para>
    /// <c>CALENDAR</c>: line up with a calendar.
    /// </para>
    /// <para>
    /// <c>CONSENT</c>: on the date of consent creation.
    /// </para>
    /// </summary>
    [JsonPropertyName("alignment")]
    public required PaymentConsentPeriodicAlignment Alignment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
