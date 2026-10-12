using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An enum indicating whether a phone number is a phone line or a fax line.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PhoneType>))]
public sealed record PhoneType : OpenStringEnum<PhoneType>
{
    private PhoneType(string value) : base(value)
    {
    }

    public static readonly PhoneType Phone = new("phone");

    public static readonly PhoneType Fax = new("fax");

    public TResult Match<TResult>(Func<TResult> onPhone, Func<TResult> onFax, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Phone => onPhone(),
            _ when this == Fax => onFax(),
            _ => otherwise(Value)
        };

    public void Match(Action onPhone, Action onFax, Action<string> otherwise)
    {
        if (this == Phone) onPhone();
        else if (this == Fax) onFax();
        else otherwise(Value);
    }
}
