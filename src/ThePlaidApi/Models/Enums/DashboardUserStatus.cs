using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The current status of the user.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DashboardUserStatus>))]
public sealed record DashboardUserStatus : OpenStringEnum<DashboardUserStatus>
{
    private DashboardUserStatus(string value) : base(value)
    {
    }

    public static readonly DashboardUserStatus Invited = new("invited");

    public static readonly DashboardUserStatus Active = new("active");

    public static readonly DashboardUserStatus Deactivated = new("deactivated");

    public TResult Match<TResult>(Func<TResult> onInvited,
        Func<TResult> onActive,
        Func<TResult> onDeactivated,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Invited => onInvited(),
            _ when this == Active => onActive(),
            _ when this == Deactivated => onDeactivated(),
            _ => otherwise(Value)
        };

    public void Match(Action onInvited, Action onActive, Action onDeactivated, Action<string> otherwise)
    {
        if (this == Invited) onInvited();
        else if (this == Active) onActive();
        else if (this == Deactivated) onDeactivated();
        else otherwise(Value);
    }
}
