using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Commonly used term to describe the earning line item.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EarningsBreakdownCanonicalDescription>))]
public sealed record EarningsBreakdownCanonicalDescription : OpenStringEnum<EarningsBreakdownCanonicalDescription>
{
    private EarningsBreakdownCanonicalDescription(string value) : base(value)
    {
    }

    public static readonly EarningsBreakdownCanonicalDescription Bonus = new("BONUS");

    public static readonly EarningsBreakdownCanonicalDescription Commission = new("COMMISSION");

    public static readonly EarningsBreakdownCanonicalDescription Overtime = new("OVERTIME");

    public static readonly EarningsBreakdownCanonicalDescription PaidTimeOff = new("PAID TIME OFF");

    public static readonly EarningsBreakdownCanonicalDescription RegularPay = new("REGULAR PAY");

    public static readonly EarningsBreakdownCanonicalDescription Vacation = new("VACATION");

    public static readonly EarningsBreakdownCanonicalDescription BasicAllowanceHousing = new("BASIC ALLOWANCE HOUSING");

    public static readonly EarningsBreakdownCanonicalDescription BasicAllowanceSubsistence = new(
        "BASIC ALLOWANCE SUBSISTENCE");

    public static readonly EarningsBreakdownCanonicalDescription Other = new("OTHER");

    public TResult Match<TResult>(Func<TResult> onBonus,
        Func<TResult> onCommission,
        Func<TResult> onOvertime,
        Func<TResult> onPaidTimeOff,
        Func<TResult> onRegularPay,
        Func<TResult> onVacation,
        Func<TResult> onBasicAllowanceHousing,
        Func<TResult> onBasicAllowanceSubsistence,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Bonus => onBonus(),
            _ when this == Commission => onCommission(),
            _ when this == Overtime => onOvertime(),
            _ when this == PaidTimeOff => onPaidTimeOff(),
            _ when this == RegularPay => onRegularPay(),
            _ when this == Vacation => onVacation(),
            _ when this == BasicAllowanceHousing => onBasicAllowanceHousing(),
            _ when this == BasicAllowanceSubsistence => onBasicAllowanceSubsistence(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onBonus,
        Action onCommission,
        Action onOvertime,
        Action onPaidTimeOff,
        Action onRegularPay,
        Action onVacation,
        Action onBasicAllowanceHousing,
        Action onBasicAllowanceSubsistence,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == Bonus) onBonus();
        else if (this == Commission) onCommission();
        else if (this == Overtime) onOvertime();
        else if (this == PaidTimeOff) onPaidTimeOff();
        else if (this == RegularPay) onRegularPay();
        else if (this == Vacation) onVacation();
        else if (this == BasicAllowanceHousing) onBasicAllowanceHousing();
        else if (this == BasicAllowanceSubsistence) onBasicAllowanceSubsistence();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
