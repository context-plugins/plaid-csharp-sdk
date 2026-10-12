using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of rate which indicates how the predicted yield was calculated. It is one of:
/// <para>
/// <c>coupon</c>: the annualized interest rate for securities with a one-year term or longer, such as treasury notes and bonds.
/// </para>
/// <para>
/// <c>coupon_equivalent</c>: the calculated equivalent for the annualized interest rate factoring in the discount rate and time to maturity, for shorter term, non-interest-bearing securities such as treasury bills.
/// </para>
/// <para>
/// <c>discount</c>: the rate at which the present value or cost is discounted from the future value upon maturity, also known as the face value.
/// </para>
/// <para>
/// <c>yield</c>: the total predicted rate of return factoring in both the discount rate and the coupon rate, applicable to securities such as exchange-traded bonds which can both be interest-bearing as well as sold at a discount off their face value.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<YieldRateType>))]
public sealed record YieldRateType : OpenStringEnum<YieldRateType>
{
    private YieldRateType(string value) : base(value)
    {
    }

    public static readonly YieldRateType Coupon = new("coupon");

    public static readonly YieldRateType CouponEquivalent = new("coupon_equivalent");

    public static readonly YieldRateType Discount = new("discount");

    public static readonly YieldRateType Yield = new("yield");

    public TResult Match<TResult>(Func<TResult> onCoupon,
        Func<TResult> onCouponEquivalent,
        Func<TResult> onDiscount,
        Func<TResult> onYield,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Coupon => onCoupon(),
            _ when this == CouponEquivalent => onCouponEquivalent(),
            _ when this == Discount => onDiscount(),
            _ when this == Yield => onYield(),
            _ => otherwise(Value)
        };

    public void Match(Action onCoupon,
        Action onCouponEquivalent,
        Action onDiscount,
        Action onYield,
        Action<string> otherwise)
    {
        if (this == Coupon) onCoupon();
        else if (this == CouponEquivalent) onCouponEquivalent();
        else if (this == Discount) onDiscount();
        else if (this == Yield) onYield();
        else otherwise(Value);
    }
}
