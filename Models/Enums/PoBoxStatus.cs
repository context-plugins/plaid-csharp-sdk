using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Field describing whether the associated address is a post office box. Will be <c>yes</c> when a P.O. box is detected, <c>no</c> when Plaid confirmed the address is not a P.O. box, and <c>no_data</c> when Plaid was not able to determine if the address is a P.O. box.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PoBoxStatus>))]
public sealed record PoBoxStatus : StringEnum<PoBoxStatus>
{
    private PoBoxStatus(string value) : base(value)
    {
    }

    public static readonly PoBoxStatus Yes = new("yes");

    public static readonly PoBoxStatus No = new("no");

    public static readonly PoBoxStatus NoData = new("no_data");

    public static PoBoxStatus FromValue(string value) => FromValueCore(value);
}
