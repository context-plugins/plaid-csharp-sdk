using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of email account as described by the financial institution.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type1>))]
public sealed record Type1 : OpenStringEnum<Type1>
{
    private Type1(string value) : base(value)
    {
    }

    public static readonly Type1 Primary = new("primary");

    public static readonly Type1 Secondary = new("secondary");

    public static readonly Type1 Other = new("other");

    public TResult Match<TResult>(Func<TResult> onPrimary,
        Func<TResult> onSecondary,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Primary => onPrimary(),
            _ when this == Secondary => onSecondary(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onPrimary, Action onSecondary, Action onOther, Action<string> otherwise)
    {
        if (this == Primary) onPrimary();
        else if (this == Secondary) onSecondary();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
