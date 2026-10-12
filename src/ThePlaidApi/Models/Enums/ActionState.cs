using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Enum representing the state of the action/activity.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ActionState>))]
public sealed record ActionState : OpenStringEnum<ActionState>
{
    private ActionState(string value) : base(value)
    {
    }

    public static readonly ActionState Unknown = new("UNKNOWN");

    public static readonly ActionState Attempt = new("ATTEMPT");

    public static readonly ActionState Success = new("SUCCESS");

    public static readonly ActionState Failure = new("FAILURE");

    public static readonly ActionState Skipped = new("SKIPPED");

    public TResult Match<TResult>(Func<TResult> onUnknown,
        Func<TResult> onAttempt,
        Func<TResult> onSuccess,
        Func<TResult> onFailure,
        Func<TResult> onSkipped,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Unknown => onUnknown(),
            _ when this == Attempt => onAttempt(),
            _ when this == Success => onSuccess(),
            _ when this == Failure => onFailure(),
            _ when this == Skipped => onSkipped(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnknown,
        Action onAttempt,
        Action onSuccess,
        Action onFailure,
        Action onSkipped,
        Action<string> otherwise)
    {
        if (this == Unknown) onUnknown();
        else if (this == Attempt) onAttempt();
        else if (this == Success) onSuccess();
        else if (this == Failure) onFailure();
        else if (this == Skipped) onSkipped();
        else otherwise(Value);
    }
}
