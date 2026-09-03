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
public sealed record OverrideAccountType : StringEnum<OverrideAccountType>
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

    public static OverrideAccountType FromValue(string value) => FromValueCore(value);
}
