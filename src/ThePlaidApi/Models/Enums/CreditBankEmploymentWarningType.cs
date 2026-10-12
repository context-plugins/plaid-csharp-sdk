using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The warning type which will always be <c>BANK_EMPLOYMENT_WARNING</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreditBankEmploymentWarningType>))]
public sealed record CreditBankEmploymentWarningType : OpenStringEnum<CreditBankEmploymentWarningType>
{
    private CreditBankEmploymentWarningType(string value) : base(value)
    {
    }

    public static readonly CreditBankEmploymentWarningType BankEmploymentWarning = new("BANK_EMPLOYMENT_WARNING");

    public TResult Match<TResult>(Func<TResult> onBankEmploymentWarning, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BankEmploymentWarning => onBankEmploymentWarning(),
            _ => otherwise(Value)
        };

    public void Match(Action onBankEmploymentWarning, Action<string> otherwise)
    {
        if (this == BankEmploymentWarning) onBankEmploymentWarning();
        else otherwise(Value);
    }
}
