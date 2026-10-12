using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The version of Prism FirstDetect. If not specified, will default to v3.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PrismFirstDetectVersion>))]
public sealed record PrismFirstDetectVersion : OpenStringEnum<PrismFirstDetectVersion>
{
    private PrismFirstDetectVersion(string value) : base(value)
    {
    }

    /// <summary>
    /// The <c>3</c> Prism FirstDetect version.
    /// </summary>
    public static readonly PrismFirstDetectVersion _3 = new("3");

    public TResult Match<TResult>(Func<TResult> on_3, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _3 => on_3(),
            _ => otherwise(Value)
        };

    public void Match(Action on_3, Action<string> otherwise)
    {
        if (this == _3) on_3();
        else otherwise(Value);
    }
}
