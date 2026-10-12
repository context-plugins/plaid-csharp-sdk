using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// <c>investment:</c> Investment account. In API versions 2018-05-22 and earlier, this type is called <c>brokerage</c> instead.
/// <para>
/// <c>credit:</c> Credit card
/// </para>
/// <para>
/// <c>depository:</c> Depository account
/// </para>
/// <para>
/// <c>loan:</c> Loan account
/// </para>
/// <para>
/// <c>other:</c> Non-specified account type
/// </para>
/// <para>
/// See the <see href="https://plaid.com/docs/api/accounts#account-type-schema">Account type schema</see> for a full listing of account types and corresponding subtypes.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountType>))]
public sealed record AccountType : OpenStringEnum<AccountType>
{
    private AccountType(string value) : base(value)
    {
    }

    public static readonly AccountType Investment = new("investment");

    public static readonly AccountType Credit = new("credit");

    public static readonly AccountType Depository = new("depository");

    public static readonly AccountType Loan = new("loan");

    public static readonly AccountType Brokerage = new("brokerage");

    public static readonly AccountType Other = new("other");

    public TResult Match<TResult>(Func<TResult> onInvestment,
        Func<TResult> onCredit,
        Func<TResult> onDepository,
        Func<TResult> onLoan,
        Func<TResult> onBrokerage,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Investment => onInvestment(),
            _ when this == Credit => onCredit(),
            _ when this == Depository => onDepository(),
            _ when this == Loan => onLoan(),
            _ when this == Brokerage => onBrokerage(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onInvestment,
        Action onCredit,
        Action onDepository,
        Action onLoan,
        Action onBrokerage,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == Investment) onInvestment();
        else if (this == Credit) onCredit();
        else if (this == Depository) onDepository();
        else if (this == Loan) onLoan();
        else if (this == Brokerage) onBrokerage();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
