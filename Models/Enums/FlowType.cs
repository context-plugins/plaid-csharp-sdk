using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// This field has been deprecated in favor of <c>auth_type_select_enabled</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FlowType>))]
public sealed record FlowType : StringEnum<FlowType>
{
    private FlowType(string value) : base(value)
    {
    }

    public static readonly FlowType FlexibleAuth = new("FLEXIBLE_AUTH");

    public static FlowType FromValue(string value) => FromValueCore(value);
}
