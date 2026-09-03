using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Form 1099 Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Form1099Type>))]
public sealed record Form1099Type : StringEnum<Form1099Type>
{
    private Form1099Type(string value) : base(value)
    {
    }

    public static readonly Form1099Type Form1099TypeUnknown = new("FORM_1099_TYPE_UNKNOWN");

    public static readonly Form1099Type Form1099TypeMisc = new("FORM_1099_TYPE_MISC");

    public static readonly Form1099Type Form1099TypeK = new("FORM_1099_TYPE_K");

    public static Form1099Type FromValue(string value) => FromValueCore(value);
}
