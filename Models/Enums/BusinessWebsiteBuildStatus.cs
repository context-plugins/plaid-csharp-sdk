using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Build status of the business website.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessWebsiteBuildStatus>))]
public sealed record BusinessWebsiteBuildStatus : StringEnum<BusinessWebsiteBuildStatus>
{
    private BusinessWebsiteBuildStatus(string value) : base(value)
    {
    }

    public static readonly BusinessWebsiteBuildStatus ComingSoon = new("coming_soon");

    public static readonly BusinessWebsiteBuildStatus Active = new("active");

    public static readonly BusinessWebsiteBuildStatus Inactive = new("inactive");

    public static BusinessWebsiteBuildStatus FromValue(string value) => FromValueCore(value);
}
