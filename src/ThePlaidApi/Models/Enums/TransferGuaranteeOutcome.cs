using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The adaptive guarantee outcome for a transfer.
/// <para>
/// <c>FULL_INSTANT</c>: The full transfer amount is guaranteed and funds are available instantly.
/// </para>
/// <para>
/// <c>PARTIAL_INSTANT_ONLY</c>: A partial amount is guaranteed and available instantly; the remainder is not guaranteed.
/// </para>
/// <para>
/// <c>PARTIAL_INSTANT_WITH_OBSERVATION_WINDOW</c>: A partial amount is guaranteed instantly; an additional amount is conditionally guaranteed subject to an observation window.
/// </para>
/// <para>
/// <c>NOT_GUARANTEED</c>: Plaid did not provide a guarantee for this transfer.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferGuaranteeOutcome>))]
public sealed record TransferGuaranteeOutcome : OpenStringEnum<TransferGuaranteeOutcome>
{
    private TransferGuaranteeOutcome(string value) : base(value)
    {
    }

    public static readonly TransferGuaranteeOutcome FullInstant = new("FULL_INSTANT");

    public static readonly TransferGuaranteeOutcome PartialInstantOnly = new("PARTIAL_INSTANT_ONLY");

    public static readonly TransferGuaranteeOutcome PartialInstantWithObservationWindow = new(
        "PARTIAL_INSTANT_WITH_OBSERVATION_WINDOW");

    public static readonly TransferGuaranteeOutcome NotGuaranteed = new("NOT_GUARANTEED");

    public TResult Match<TResult>(Func<TResult> onFullInstant,
        Func<TResult> onPartialInstantOnly,
        Func<TResult> onPartialInstantWithObservationWindow,
        Func<TResult> onNotGuaranteed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FullInstant => onFullInstant(),
            _ when this == PartialInstantOnly => onPartialInstantOnly(),
            _ when this == PartialInstantWithObservationWindow => onPartialInstantWithObservationWindow(),
            _ when this == NotGuaranteed => onNotGuaranteed(),
            _ => otherwise(Value)
        };

    public void Match(Action onFullInstant,
        Action onPartialInstantOnly,
        Action onPartialInstantWithObservationWindow,
        Action onNotGuaranteed,
        Action<string> otherwise)
    {
        if (this == FullInstant) onFullInstant();
        else if (this == PartialInstantOnly) onPartialInstantOnly();
        else if (this == PartialInstantWithObservationWindow) onPartialInstantWithObservationWindow();
        else if (this == NotGuaranteed) onNotGuaranteed();
        else otherwise(Value);
    }
}
