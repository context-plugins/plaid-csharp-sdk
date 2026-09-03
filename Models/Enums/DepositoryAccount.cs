using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An account type holding cash, in which funds are deposited.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DepositoryAccount>))]
public sealed record DepositoryAccount : StringEnum<DepositoryAccount>
{
    private DepositoryAccount(string value) : base(value)
    {
    }

    public static readonly DepositoryAccount CashManagement = new("cash management");

    public static readonly DepositoryAccount Cd = new("cd");

    public static readonly DepositoryAccount Checking = new("checking");

    public static readonly DepositoryAccount Ebt = new("ebt");

    public static readonly DepositoryAccount Hsa = new("hsa");

    public static readonly DepositoryAccount LimitedPurposeChecking = new("limited purpose checking");

    public static readonly DepositoryAccount MoneyMarket = new("money market");

    public static readonly DepositoryAccount Paypal = new("paypal");

    public static readonly DepositoryAccount Prepaid = new("prepaid");

    public static readonly DepositoryAccount Savings = new("savings");

    public static DepositoryAccount FromValue(string value) => FromValueCore(value);
}
