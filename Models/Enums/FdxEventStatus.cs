using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Current status of indicated entity after reported event change. Not all statuses will be supported on all entity types by all data providers
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FdxEventStatus>))]
public sealed record FdxEventStatus : StringEnum<FdxEventStatus>
{
    private FdxEventStatus(string value) : base(value)
    {
    }

    public static readonly FdxEventStatus Active = new("ACTIVE");

    public static readonly FdxEventStatus Expired = new("EXPIRED");

    public static readonly FdxEventStatus Revoked = new("REVOKED");

    public static readonly FdxEventStatus Suspended = new("SUSPENDED");

    public static FdxEventStatus FromValue(string value) => FromValueCore(value);
}
