using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the incident.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status1>))]
public sealed record Status1 : StringEnum<Status1>
{
    private Status1(string value) : base(value)
    {
    }

    public static readonly Status1 Investigating = new("INVESTIGATING");

    public static readonly Status1 Identified = new("IDENTIFIED");

    public static readonly Status1 Scheduled = new("SCHEDULED");

    public static readonly Status1 Resolved = new("RESOLVED");

    public static readonly Status1 Unknown = new("UNKNOWN");

    public static Status1 FromValue(string value) => FromValueCore(value);
}
