using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of phone number.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeEnum>))]
public sealed record TypeEnum : OpenStringEnum<TypeEnum>
{
    private TypeEnum(string value) : base(value)
    {
    }

    public static readonly TypeEnum Home = new("home");

    public static readonly TypeEnum Work = new("work");

    public static readonly TypeEnum Office = new("office");

    public static readonly TypeEnum Mobile = new("mobile");

    public static readonly TypeEnum Mobile1 = new("mobile1");

    public static readonly TypeEnum Other = new("other");

    public TResult Match<TResult>(Func<TResult> onHome,
        Func<TResult> onWork,
        Func<TResult> onOffice,
        Func<TResult> onMobile,
        Func<TResult> onMobile1,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Home => onHome(),
            _ when this == Work => onWork(),
            _ when this == Office => onOffice(),
            _ when this == Mobile => onMobile(),
            _ when this == Mobile1 => onMobile1(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onHome,
        Action onWork,
        Action onOffice,
        Action onMobile,
        Action onMobile1,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == Home) onHome();
        else if (this == Work) onWork();
        else if (this == Office) onOffice();
        else if (this == Mobile) onMobile();
        else if (this == Mobile1) onMobile1();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
