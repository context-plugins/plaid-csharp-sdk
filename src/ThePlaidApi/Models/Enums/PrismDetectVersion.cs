using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The version of Prism Detect
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PrismDetectVersion>))]
public sealed record PrismDetectVersion : OpenStringEnum<PrismDetectVersion>
{
    private PrismDetectVersion(string value) : base(value)
    {
    }

    /// <summary>
    /// The <c>4.1</c> Prism Detect version.
    /// </summary>
    public static readonly PrismDetectVersion _41 = new("4.1");

    /// <summary>
    /// The <c>4</c> Prism Detect version.
    /// </summary>
    public static readonly PrismDetectVersion _4 = new("4");

    public TResult Match<TResult>(Func<TResult> on_41, Func<TResult> on_4, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _41 => on_41(),
            _ when this == _4 => on_4(),
            _ => otherwise(Value)
        };

    public void Match(Action on_41, Action on_4, Action<string> otherwise)
    {
        if (this == _41) on_41();
        else if (this == _4) on_4();
        else otherwise(Value);
    }
}
