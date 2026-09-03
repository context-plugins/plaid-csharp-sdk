using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of phone number.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeEnum>))]
public sealed record TypeEnum : StringEnum<TypeEnum>
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

    public static TypeEnum FromValue(string value) => FromValueCore(value);
}
