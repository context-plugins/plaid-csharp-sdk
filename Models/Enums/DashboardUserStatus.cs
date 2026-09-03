using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The current status of the user.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DashboardUserStatus>))]
public sealed record DashboardUserStatus : StringEnum<DashboardUserStatus>
{
    private DashboardUserStatus(string value) : base(value)
    {
    }

    public static readonly DashboardUserStatus Invited = new("invited");

    public static readonly DashboardUserStatus Active = new("active");

    public static readonly DashboardUserStatus Deactivated = new("deactivated");

    public static DashboardUserStatus FromValue(string value) => FromValueCore(value);
}
