using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Details about a fixed income security's expected rate of return.
/// </summary>
public record YieldRate
{
    /// <summary>
    /// The fixed income security's expected rate of return.
    /// </summary>
    [JsonPropertyName("percentage")]
    public required double Percentage { get; init; }

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
    [JsonPropertyName("type")]
    public required YieldRateType? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
