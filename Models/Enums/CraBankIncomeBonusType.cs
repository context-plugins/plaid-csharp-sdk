using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of bonus that this transaction represents, if it is a bonus.
/// <c>BONUS_INCLUDED</c>: Bonus is included in this transaction along with the normal pay
/// <c>BONUS_ONLY</c>: This transaction is a standalone bonus
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraBankIncomeBonusType>))]
public sealed record CraBankIncomeBonusType : StringEnum<CraBankIncomeBonusType>
{
    private CraBankIncomeBonusType(string value) : base(value)
    {
    }

    public static readonly CraBankIncomeBonusType BonusIncluded = new("BONUS_INCLUDED");

    public static readonly CraBankIncomeBonusType BonusOnly = new("BONUS_ONLY");

    public static CraBankIncomeBonusType FromValue(string value) => FromValueCore(value);
}
