using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Value is one of the following:
/// <c>buy</c>: Buying an investment
/// <c>sell</c>: Selling an investment
/// <c>cancel</c>: A cancellation of a pending transaction
/// <c>cash</c>: Activity that modifies a cash position
/// <c>fee</c>: A fee on the account
/// <c>transfer</c>: Activity which modifies a position, but not through buy/sell activity e.g. options exercise, portfolio transfer
/// <para>
/// For descriptions of possible transaction types and subtypes, see the <see href="https://plaid.com/docs/api/accounts/#investment-transaction-types-schema">Investment transaction types schema</see>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvestmentTransactionType>))]
public sealed record InvestmentTransactionType : StringEnum<InvestmentTransactionType>
{
    private InvestmentTransactionType(string value) : base(value)
    {
    }

    public static readonly InvestmentTransactionType Buy = new("buy");

    public static readonly InvestmentTransactionType Sell = new("sell");

    public static readonly InvestmentTransactionType Cancel = new("cancel");

    public static readonly InvestmentTransactionType Cash = new("cash");

    public static readonly InvestmentTransactionType Fee = new("fee");

    public static readonly InvestmentTransactionType Transfer = new("transfer");

    public static InvestmentTransactionType FromValue(string value) => FromValueCore(value);
}
