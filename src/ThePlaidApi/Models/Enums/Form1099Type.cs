using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Form 1099 Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Form1099Type>))]
public sealed record Form1099Type : OpenStringEnum<Form1099Type>
{
    private Form1099Type(string value) : base(value)
    {
    }

    public static readonly Form1099Type Form1099TypeUnknown = new("FORM_1099_TYPE_UNKNOWN");

    public static readonly Form1099Type Form1099TypeMisc = new("FORM_1099_TYPE_MISC");

    public static readonly Form1099Type Form1099TypeK = new("FORM_1099_TYPE_K");

    public TResult Match<TResult>(Func<TResult> onForm1099TypeUnknown,
        Func<TResult> onForm1099TypeMisc,
        Func<TResult> onForm1099TypeK,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Form1099TypeUnknown => onForm1099TypeUnknown(),
            _ when this == Form1099TypeMisc => onForm1099TypeMisc(),
            _ when this == Form1099TypeK => onForm1099TypeK(),
            _ => otherwise(Value)
        };

    public void Match(Action onForm1099TypeUnknown,
        Action onForm1099TypeMisc,
        Action onForm1099TypeK,
        Action<string> otherwise)
    {
        if (this == Form1099TypeUnknown) onForm1099TypeUnknown();
        else if (this == Form1099TypeMisc) onForm1099TypeMisc();
        else if (this == Form1099TypeK) onForm1099TypeK();
        else otherwise(Value);
    }
}
