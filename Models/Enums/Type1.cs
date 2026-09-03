using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of email account as described by the financial institution.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type1>))]
public sealed record Type1 : StringEnum<Type1>
{
    private Type1(string value) : base(value)
    {
    }

    public static readonly Type1 Primary = new("primary");

    public static readonly Type1 Secondary = new("secondary");

    public static readonly Type1 Other = new("other");

    public static Type1 FromValue(string value) => FromValueCore(value);
}
