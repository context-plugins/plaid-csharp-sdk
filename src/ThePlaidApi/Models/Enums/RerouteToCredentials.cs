using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Specifies what type of <see href="https://plaid.com/docs/auth/coverage/flow-options/#removing-manual-verification-entry-points-with-reroute-to-credentials">Reroute to Credentials</see> pane should be used in the Link session for the Same-Day Micro-deposits flow. Default behavior is <c>OPTIONAL</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RerouteToCredentials>))]
public sealed record RerouteToCredentials : OpenStringEnum<RerouteToCredentials>
{
    private RerouteToCredentials(string value) : base(value)
    {
    }

    public static readonly RerouteToCredentials Off = new("OFF");

    public static readonly RerouteToCredentials Optional = new("OPTIONAL");

    public static readonly RerouteToCredentials Forced = new("FORCED");

    public TResult Match<TResult>(Func<TResult> onOff,
        Func<TResult> onOptional,
        Func<TResult> onForced,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Off => onOff(),
            _ when this == Optional => onOptional(),
            _ when this == Forced => onForced(),
            _ => otherwise(Value)
        };

    public void Match(Action onOff, Action onOptional, Action onForced, Action<string> otherwise)
    {
        if (this == Off) onOff();
        else if (this == Optional) onOptional();
        else if (this == Forced) onForced();
        else otherwise(Value);
    }
}
