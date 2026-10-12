using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the incident.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status1>))]
public sealed record Status1 : OpenStringEnum<Status1>
{
    private Status1(string value) : base(value)
    {
    }

    public static readonly Status1 Investigating = new("INVESTIGATING");

    public static readonly Status1 Identified = new("IDENTIFIED");

    public static readonly Status1 Scheduled = new("SCHEDULED");

    public static readonly Status1 Resolved = new("RESOLVED");

    public static readonly Status1 Unknown = new("UNKNOWN");

    public TResult Match<TResult>(Func<TResult> onInvestigating,
        Func<TResult> onIdentified,
        Func<TResult> onScheduled,
        Func<TResult> onResolved,
        Func<TResult> onUnknown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Investigating => onInvestigating(),
            _ when this == Identified => onIdentified(),
            _ when this == Scheduled => onScheduled(),
            _ when this == Resolved => onResolved(),
            _ when this == Unknown => onUnknown(),
            _ => otherwise(Value)
        };

    public void Match(Action onInvestigating,
        Action onIdentified,
        Action onScheduled,
        Action onResolved,
        Action onUnknown,
        Action<string> otherwise)
    {
        if (this == Investigating) onInvestigating();
        else if (this == Identified) onIdentified();
        else if (this == Scheduled) onScheduled();
        else if (this == Resolved) onResolved();
        else if (this == Unknown) onUnknown();
        else otherwise(Value);
    }
}
