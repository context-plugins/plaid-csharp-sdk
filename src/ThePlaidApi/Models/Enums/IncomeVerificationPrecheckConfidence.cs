using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The confidence that Plaid can support the user in the digital income verification flow instead of requiring a manual paystub upload. One of the following:
/// <para>
/// <c>"HIGH"</c>: It is very likely that this user can use the digital income verification flow.
/// </para>
/// <para>
/// "<c>LOW</c>": It is unlikely that this user can use the digital income verification flow.
/// </para>
/// <para>
/// <c>"UNKNOWN"</c>: It was not possible to determine if the user is supportable with the information passed.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IncomeVerificationPrecheckConfidence>))]
public sealed record IncomeVerificationPrecheckConfidence : OpenStringEnum<IncomeVerificationPrecheckConfidence>
{
    private IncomeVerificationPrecheckConfidence(string value) : base(value)
    {
    }

    public static readonly IncomeVerificationPrecheckConfidence High = new("HIGH");

    public static readonly IncomeVerificationPrecheckConfidence Low = new("LOW");

    public static readonly IncomeVerificationPrecheckConfidence Unknown = new("UNKNOWN");

    public TResult Match<TResult>(Func<TResult> onHigh,
        Func<TResult> onLow,
        Func<TResult> onUnknown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == High => onHigh(),
            _ when this == Low => onLow(),
            _ when this == Unknown => onUnknown(),
            _ => otherwise(Value)
        };

    public void Match(Action onHigh, Action onLow, Action onUnknown, Action<string> otherwise)
    {
        if (this == High) onHigh();
        else if (this == Low) onLow();
        else if (this == Unknown) onUnknown();
        else otherwise(Value);
    }
}
