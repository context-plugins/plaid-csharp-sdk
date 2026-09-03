using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Valid account subtypes for depository accounts. For a list containing descriptions of each subtype, see <see href="https://plaid.com/docs/api/accounts/#StandaloneAccountType-depository">Account schemas</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DepositoryAccountSubtype>))]
public sealed record DepositoryAccountSubtype : StringEnum<DepositoryAccountSubtype>
{
    private DepositoryAccountSubtype(string value) : base(value)
    {
    }

    public static readonly DepositoryAccountSubtype Checking = new("checking");

    public static readonly DepositoryAccountSubtype Savings = new("savings");

    public static readonly DepositoryAccountSubtype Hsa = new("hsa");

    public static readonly DepositoryAccountSubtype Cd = new("cd");

    public static readonly DepositoryAccountSubtype MoneyMarket = new("money market");

    public static readonly DepositoryAccountSubtype Paypal = new("paypal");

    public static readonly DepositoryAccountSubtype Prepaid = new("prepaid");

    public static readonly DepositoryAccountSubtype CashManagement = new("cash management");

    public static readonly DepositoryAccountSubtype Ebt = new("ebt");

    public static readonly DepositoryAccountSubtype LimitedPurposeChecking = new("limited purpose checking");

    public static readonly DepositoryAccountSubtype All = new("all");

    public static DepositoryAccountSubtype FromValue(string value) => FromValueCore(value);
}
