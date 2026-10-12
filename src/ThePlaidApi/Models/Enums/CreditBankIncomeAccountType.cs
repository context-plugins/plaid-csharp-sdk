using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The account type. This will always be <c>depository</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreditBankIncomeAccountType>))]
public sealed record CreditBankIncomeAccountType : OpenStringEnum<CreditBankIncomeAccountType>
{
    private CreditBankIncomeAccountType(string value) : base(value)
    {
    }

    public static readonly CreditBankIncomeAccountType Depository = new("depository");

    public TResult Match<TResult>(Func<TResult> onDepository, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Depository => onDepository(),
            _ => otherwise(Value)
        };

    public void Match(Action onDepository, Action<string> otherwise)
    {
        if (this == Depository) onDepository();
        else otherwise(Value);
    }
}
