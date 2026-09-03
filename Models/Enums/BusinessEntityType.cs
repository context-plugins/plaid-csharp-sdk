using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The legal structure or type of business entity
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessEntityType>))]
public sealed record BusinessEntityType : StringEnum<BusinessEntityType>
{
    private BusinessEntityType(string value) : base(value)
    {
    }

    public static readonly BusinessEntityType SoleProprietorship = new("sole_proprietorship");

    public static readonly BusinessEntityType GeneralPartnership = new("general_partnership");

    public static readonly BusinessEntityType Llc = new("llc");

    public static readonly BusinessEntityType Llp = new("llp");

    public static readonly BusinessEntityType Lllp = new("lllp");

    public static readonly BusinessEntityType Lp = new("lp");

    public static readonly BusinessEntityType CCorporation = new("c_corporation");

    public static readonly BusinessEntityType SCorporation = new("s_corporation");

    public static readonly BusinessEntityType BCorporation = new("b_corporation");

    public static readonly BusinessEntityType Nonprofit = new("nonprofit");

    public static readonly BusinessEntityType Cooperative = new("cooperative");

    public static readonly BusinessEntityType Trust = new("trust");

    public static readonly BusinessEntityType ProfessionalAssociation = new("professional_association");

    public static readonly BusinessEntityType ProfessionalCorporation = new("professional_corporation");

    public static readonly BusinessEntityType TradeName = new("trade_name");

    public static readonly BusinessEntityType Bank = new("bank");

    public static readonly BusinessEntityType CreditUnion = new("credit_union");

    public static readonly BusinessEntityType Insurance = new("insurance");

    public static readonly BusinessEntityType Other = new("other");

    public static readonly BusinessEntityType Unknown = new("unknown");

    public static BusinessEntityType FromValue(string value) => FromValueCore(value);
}
