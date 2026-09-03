using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A specific use case for a limited purpose checking account. Limited purpose checking accounts will reject or return ACH transactions that aren't for eligible use cases. For example, a <c>RENT_MORTGAGE</c> limited purpose checking account will reject ACH transactions that are not specifically rent or mortgage payments.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LimitedPurposeType>))]
public sealed record LimitedPurposeType : StringEnum<LimitedPurposeType>
{
    private LimitedPurposeType(string value) : base(value)
    {
    }

    public static readonly LimitedPurposeType RentMortgage = new("RENT_MORTGAGE");

    public static LimitedPurposeType FromValue(string value) => FromValueCore(value);
}
