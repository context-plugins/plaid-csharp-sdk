using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The result of the bank income refresh report generation
/// <para>
/// <c>SUCCESS</c>: The refreshed report was successfully generated and can be retrieved via <c>/credit/bank_income/get</c>.
/// </para>
/// <para>
/// <c>FAILURE</c>: The refreshed report failed to be generated
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BankIncomeRefreshCompleteResult>))]
public sealed record BankIncomeRefreshCompleteResult : StringEnum<BankIncomeRefreshCompleteResult>
{
    private BankIncomeRefreshCompleteResult(string value) : base(value)
    {
    }

    public static readonly BankIncomeRefreshCompleteResult Success = new("SUCCESS");

    public static readonly BankIncomeRefreshCompleteResult Failure = new("FAILURE");

    public static BankIncomeRefreshCompleteResult FromValue(string value) => FromValueCore(value);
}
