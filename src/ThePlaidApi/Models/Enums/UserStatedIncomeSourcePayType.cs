using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The pay type - <c>GROSS</c>, <c>NET</c>, or <c>UNKNOWN</c> for a specified income source
/// </summary>
[JsonConverter(typeof(StringEnumConverter<UserStatedIncomeSourcePayType>))]
public sealed record UserStatedIncomeSourcePayType : OpenStringEnum<UserStatedIncomeSourcePayType>
{
    private UserStatedIncomeSourcePayType(string value) : base(value)
    {
    }

    public static readonly UserStatedIncomeSourcePayType Unknown = new("UNKNOWN");

    public static readonly UserStatedIncomeSourcePayType Gross = new("GROSS");

    public static readonly UserStatedIncomeSourcePayType Net = new("NET");

    public TResult Match<TResult>(Func<TResult> onUnknown,
        Func<TResult> onGross,
        Func<TResult> onNet,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Unknown => onUnknown(),
            _ when this == Gross => onGross(),
            _ when this == Net => onNet(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnknown, Action onGross, Action onNet, Action<string> otherwise)
    {
        if (this == Unknown) onUnknown();
        else if (this == Gross) onGross();
        else if (this == Net) onNet();
        else otherwise(Value);
    }
}
