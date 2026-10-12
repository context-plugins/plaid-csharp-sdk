using System;
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
public sealed record BankIncomeRefreshCompleteResult : OpenStringEnum<BankIncomeRefreshCompleteResult>
{
    private BankIncomeRefreshCompleteResult(string value) : base(value)
    {
    }

    public static readonly BankIncomeRefreshCompleteResult Success = new("SUCCESS");

    public static readonly BankIncomeRefreshCompleteResult Failure = new("FAILURE");

    public TResult Match<TResult>(Func<TResult> onSuccess, Func<TResult> onFailure, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Success => onSuccess(),
            _ when this == Failure => onFailure(),
            _ => otherwise(Value)
        };

    public void Match(Action onSuccess, Action onFailure, Action<string> otherwise)
    {
        if (this == Success) onSuccess();
        else if (this == Failure) onFailure();
        else otherwise(Value);
    }
}
