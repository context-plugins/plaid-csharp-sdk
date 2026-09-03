using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The tier of the user.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraUserTier>))]
public sealed record CraUserTier : StringEnum<CraUserTier>
{
    private CraUserTier(string value) : base(value)
    {
    }

    public static readonly CraUserTier Free = new("free");

    public static readonly CraUserTier Paid = new("paid");

    public static CraUserTier FromValue(string value) => FromValueCore(value);
}
