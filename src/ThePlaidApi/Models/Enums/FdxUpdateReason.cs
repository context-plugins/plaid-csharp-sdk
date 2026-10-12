using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Reason for lifecycle event status change
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FdxUpdateReason>))]
public sealed record FdxUpdateReason : OpenStringEnum<FdxUpdateReason>
{
    private FdxUpdateReason(string value) : base(value)
    {
    }

    public static readonly FdxUpdateReason BusinessRule = new("BUSINESS_RULE");

    public static readonly FdxUpdateReason SecurityEvent = new("SECURITY_EVENT");

    public static readonly FdxUpdateReason UserAction = new("USER_ACTION");

    public static readonly FdxUpdateReason Other = new("OTHER");

    public TResult Match<TResult>(Func<TResult> onBusinessRule,
        Func<TResult> onSecurityEvent,
        Func<TResult> onUserAction,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BusinessRule => onBusinessRule(),
            _ when this == SecurityEvent => onSecurityEvent(),
            _ when this == UserAction => onUserAction(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onBusinessRule,
        Action onSecurityEvent,
        Action onUserAction,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == BusinessRule) onBusinessRule();
        else if (this == SecurityEvent) onSecurityEvent();
        else if (this == UserAction) onUserAction();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
