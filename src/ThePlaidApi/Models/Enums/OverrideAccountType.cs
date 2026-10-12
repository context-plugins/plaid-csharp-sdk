using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// <c>investment:</c> Investment account.
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
/// <c>payroll:</c> Payroll account
/// </para>
/// <para>
/// <c>other:</c> Non-specified account type
/// </para>
/// <para>
/// See the <see href="https://plaid.com/docs/api/accounts#account-type-schema">Account type schema</see> for a full listing of account types and corresponding subtypes.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OverrideAccountType>))]
public sealed record OverrideAccountType : OpenStringEnum<OverrideAccountType>
{
    private OverrideAccountType(string value) : base(value)
    {
    }

    public static readonly OverrideAccountType Investment = new("investment");

    public static readonly OverrideAccountType Credit = new("credit");

    public static readonly OverrideAccountType Depository = new("depository");

    public static readonly OverrideAccountType Loan = new("loan");

    public static readonly OverrideAccountType Payroll = new("payroll");

    public static readonly OverrideAccountType Other = new("other");

    public TResult Match<TResult>(Func<TResult> onInvestment,
        Func<TResult> onCredit,
        Func<TResult> onDepository,
        Func<TResult> onLoan,
        Func<TResult> onPayroll,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Investment => onInvestment(),
            _ when this == Credit => onCredit(),
            _ when this == Depository => onDepository(),
            _ when this == Loan => onLoan(),
            _ when this == Payroll => onPayroll(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onInvestment,
        Action onCredit,
        Action onDepository,
        Action onLoan,
        Action onPayroll,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == Investment) onInvestment();
        else if (this == Credit) onCredit();
        else if (this == Depository) onDepository();
        else if (this == Loan) onLoan();
        else if (this == Payroll) onPayroll();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
