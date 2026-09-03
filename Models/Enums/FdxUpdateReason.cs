using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Reason for lifecycle event status change
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FdxUpdateReason>))]
public sealed record FdxUpdateReason : StringEnum<FdxUpdateReason>
{
    private FdxUpdateReason(string value) : base(value)
    {
    }

    public static readonly FdxUpdateReason BusinessRule = new("BUSINESS_RULE");

    public static readonly FdxUpdateReason SecurityEvent = new("SECURITY_EVENT");

    public static readonly FdxUpdateReason UserAction = new("USER_ACTION");

    public static readonly FdxUpdateReason Other = new("OTHER");

    public static FdxUpdateReason FromValue(string value) => FromValueCore(value);
}
