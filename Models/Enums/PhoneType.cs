using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An enum indicating whether a phone number is a phone line or a fax line.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PhoneType>))]
public sealed record PhoneType : StringEnum<PhoneType>
{
    private PhoneType(string value) : base(value)
    {
    }

    public static readonly PhoneType Phone = new("phone");

    public static readonly PhoneType Fax = new("fax");

    public static PhoneType FromValue(string value) => FromValueCore(value);
}
