using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of bonus that this transaction represents, if it is a bonus.
/// <c>BONUS_INCLUDED</c>: Bonus is included in this transaction along with the normal pay
/// <c>BONUS_ONLY</c>: This transaction is a standalone bonus
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraBankIncomeBonusType>))]
public sealed record CraBankIncomeBonusType : OpenStringEnum<CraBankIncomeBonusType>
{
    private CraBankIncomeBonusType(string value) : base(value)
    {
    }

    public static readonly CraBankIncomeBonusType BonusIncluded = new("BONUS_INCLUDED");

    public static readonly CraBankIncomeBonusType BonusOnly = new("BONUS_ONLY");

    public TResult Match<TResult>(Func<TResult> onBonusIncluded,
        Func<TResult> onBonusOnly,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BonusIncluded => onBonusIncluded(),
            _ when this == BonusOnly => onBonusOnly(),
            _ => otherwise(Value)
        };

    public void Match(Action onBonusIncluded, Action onBonusOnly, Action<string> otherwise)
    {
        if (this == BonusIncluded) onBonusIncluded();
        else if (this == BonusOnly) onBonusOnly();
        else otherwise(Value);
    }
}
