using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A type indicating who or what last touched this object. <c>dashboard</c>, <c>link</c>, and <c>api</c> indicate the originating surface; <c>system</c> indicates Plaid. <c>retro</c> indicates a screening created retroactively via a bulk screening creation.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Source>))]
public sealed record Source : OpenStringEnum<Source>
{
    private Source(string value) : base(value)
    {
    }

    public static readonly Source Dashboard = new("dashboard");

    public static readonly Source Link = new("link");

    public static readonly Source Api = new("api");

    public static readonly Source System = new("system");

    public static readonly Source Retro = new("retro");

    public TResult Match<TResult>(Func<TResult> onDashboard,
        Func<TResult> onLink,
        Func<TResult> onApi,
        Func<TResult> onSystem,
        Func<TResult> onRetro,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Dashboard => onDashboard(),
            _ when this == Link => onLink(),
            _ when this == Api => onApi(),
            _ when this == System => onSystem(),
            _ when this == Retro => onRetro(),
            _ => otherwise(Value)
        };

    public void Match(Action onDashboard,
        Action onLink,
        Action onApi,
        Action onSystem,
        Action onRetro,
        Action<string> otherwise)
    {
        if (this == Dashboard) onDashboard();
        else if (this == Link) onLink();
        else if (this == Api) onApi();
        else if (this == System) onSystem();
        else if (this == Retro) onRetro();
        else otherwise(Value);
    }
}
