using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates the account's categorization as either a personal or a business account. This field is currently in beta; to request access, contact your account manager.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<HolderCategory>))]
public sealed record HolderCategory : StringEnum<HolderCategory>
{
    private HolderCategory(string value) : base(value)
    {
    }

    public static readonly HolderCategory Business = new("business");

    public static readonly HolderCategory Personal = new("personal");

    public static readonly HolderCategory Unrecognized = new("unrecognized");

    public static HolderCategory FromValue(string value) => FromValueCore(value);
}
