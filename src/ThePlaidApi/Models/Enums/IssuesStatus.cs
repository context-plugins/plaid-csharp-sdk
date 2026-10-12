using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The current status of the issue.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IssuesStatus>))]
public sealed record IssuesStatus : OpenStringEnum<IssuesStatus>
{
    private IssuesStatus(string value) : base(value)
    {
    }

    public static readonly IssuesStatus Reported = new("REPORTED");

    public static readonly IssuesStatus AwaitingResolution = new("AWAITING_RESOLUTION");

    public static readonly IssuesStatus FixInProgress = new("FIX_IN_PROGRESS");

    public static readonly IssuesStatus FixPendingValidation = new("FIX_PENDING_VALIDATION");

    public static readonly IssuesStatus CannotFix = new("CANNOT_FIX");

    public static readonly IssuesStatus Resolved = new("RESOLVED");

    public TResult Match<TResult>(Func<TResult> onReported,
        Func<TResult> onAwaitingResolution,
        Func<TResult> onFixInProgress,
        Func<TResult> onFixPendingValidation,
        Func<TResult> onCannotFix,
        Func<TResult> onResolved,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Reported => onReported(),
            _ when this == AwaitingResolution => onAwaitingResolution(),
            _ when this == FixInProgress => onFixInProgress(),
            _ when this == FixPendingValidation => onFixPendingValidation(),
            _ when this == CannotFix => onCannotFix(),
            _ when this == Resolved => onResolved(),
            _ => otherwise(Value)
        };

    public void Match(Action onReported,
        Action onAwaitingResolution,
        Action onFixInProgress,
        Action onFixPendingValidation,
        Action onCannotFix,
        Action onResolved,
        Action<string> otherwise)
    {
        if (this == Reported) onReported();
        else if (this == AwaitingResolution) onAwaitingResolution();
        else if (this == FixInProgress) onFixInProgress();
        else if (this == FixPendingValidation) onFixPendingValidation();
        else if (this == CannotFix) onCannotFix();
        else if (this == Resolved) onResolved();
        else otherwise(Value);
    }
}
