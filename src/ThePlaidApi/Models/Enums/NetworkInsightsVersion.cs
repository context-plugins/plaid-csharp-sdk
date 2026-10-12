using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The version of Network Insights. Required if using Network Insights.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NetworkInsightsVersion>))]
public sealed record NetworkInsightsVersion : OpenStringEnum<NetworkInsightsVersion>
{
    private NetworkInsightsVersion(string value) : base(value)
    {
    }

    public static readonly NetworkInsightsVersion Ni1 = new("NI1");

    public TResult Match<TResult>(Func<TResult> onNi1, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ni1 => onNi1(),
            _ => otherwise(Value)
        };

    public void Match(Action onNi1, Action<string> otherwise)
    {
        if (this == Ni1) onNi1();
        else otherwise(Value);
    }
}
