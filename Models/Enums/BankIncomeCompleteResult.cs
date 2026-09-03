using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The result of the bank income report generation
/// <para>
/// <c>SUCCESS</c>: The bank income report was successfully generated and can be retrieved via <c>/credit/bank_income/get</c>.
/// </para>
/// <para>
/// <c>FAILURE</c>: The bank income report failed to be generated
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BankIncomeCompleteResult>))]
public sealed record BankIncomeCompleteResult : StringEnum<BankIncomeCompleteResult>
{
    private BankIncomeCompleteResult(string value) : base(value)
    {
    }

    public static readonly BankIncomeCompleteResult Success = new("SUCCESS");

    public static readonly BankIncomeCompleteResult Failure = new("FAILURE");

    public static BankIncomeCompleteResult FromValue(string value) => FromValueCore(value);
}
