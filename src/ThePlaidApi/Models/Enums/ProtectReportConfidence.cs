using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The confidence level of the incident report.
/// <c>CONFIRMED</c> indicates the incident has been verified and definitively occurred.
/// <para>
/// <c>SUSPECTED</c> indicates the incident is believed to have occurred but has not been fully verified.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ProtectReportConfidence>))]
public sealed record ProtectReportConfidence : OpenStringEnum<ProtectReportConfidence>
{
    private ProtectReportConfidence(string value) : base(value)
    {
    }

    public static readonly ProtectReportConfidence Confirmed = new("CONFIRMED");

    public static readonly ProtectReportConfidence Suspected = new("SUSPECTED");

    public TResult Match<TResult>(Func<TResult> onConfirmed,
        Func<TResult> onSuspected,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Confirmed => onConfirmed(),
            _ when this == Suspected => onSuspected(),
            _ => otherwise(Value)
        };

    public void Match(Action onConfirmed, Action onSuspected, Action<string> otherwise)
    {
        if (this == Confirmed) onConfirmed();
        else if (this == Suspected) onSuspected();
        else otherwise(Value);
    }
}
