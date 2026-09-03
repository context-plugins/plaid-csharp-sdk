using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Status of the digital presence check
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessVerificationStatusWebPresenceCheck>))]
public sealed record BusinessVerificationStatusWebPresenceCheck : StringEnum<BusinessVerificationStatusWebPresenceCheck>
{
    private BusinessVerificationStatusWebPresenceCheck(string value) : base(value)
    {
    }

    public static readonly BusinessVerificationStatusWebPresenceCheck Active = new("active");

    public static readonly BusinessVerificationStatusWebPresenceCheck Success = new("success");

    public static readonly BusinessVerificationStatusWebPresenceCheck Failed = new("failed");

    public static readonly BusinessVerificationStatusWebPresenceCheck NotApplicable = new("not_applicable");

    public static BusinessVerificationStatusWebPresenceCheck FromValue(string value) => FromValueCore(value);
}
