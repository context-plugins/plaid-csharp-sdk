using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of the transaction.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type4>))]
public sealed record Type4 : StringEnum<Type4>
{
    private Type4(string value) : base(value)
    {
    }

    public static readonly Type4 Payout = new("PAYOUT");

    public static readonly Type4 Return = new("RETURN");

    public static readonly Type4 Refund = new("REFUND");

    public static readonly Type4 FundsSweep = new("FUNDS_SWEEP");

    public static Type4 FromValue(string value) => FromValueCore(value);
}
