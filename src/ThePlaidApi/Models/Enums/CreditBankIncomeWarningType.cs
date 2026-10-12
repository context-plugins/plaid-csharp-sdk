using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The warning type which will always be <c>BANK_INCOME_WARNING</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreditBankIncomeWarningType>))]
public sealed record CreditBankIncomeWarningType : OpenStringEnum<CreditBankIncomeWarningType>
{
    private CreditBankIncomeWarningType(string value) : base(value)
    {
    }

    public static readonly CreditBankIncomeWarningType BankIncomeWarning = new("BANK_INCOME_WARNING");

    public TResult Match<TResult>(Func<TResult> onBankIncomeWarning, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BankIncomeWarning => onBankIncomeWarning(),
            _ => otherwise(Value)
        };

    public void Match(Action onBankIncomeWarning, Action<string> otherwise)
    {
        if (this == BankIncomeWarning) onBankIncomeWarning();
        else otherwise(Value);
    }
}
