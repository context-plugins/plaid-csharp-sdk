using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The account type. This will always be <c>depository</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreditBankIncomeAccountType>))]
public sealed record CreditBankIncomeAccountType : StringEnum<CreditBankIncomeAccountType>
{
    private CreditBankIncomeAccountType(string value) : base(value)
    {
    }

    public static readonly CreditBankIncomeAccountType Depository = new("depository");

    public static CreditBankIncomeAccountType FromValue(string value) => FromValueCore(value);
}
