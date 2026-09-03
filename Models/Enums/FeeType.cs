using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Fees on the account, e.g. commission, bookkeeping, options-related.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FeeType>))]
public sealed record FeeType : StringEnum<FeeType>
{
    private FeeType(string value) : base(value)
    {
    }

    public static readonly FeeType AccountFee = new("account fee");

    public static readonly FeeType Adjustment = new("adjustment");

    public static readonly FeeType Dividend = new("dividend");

    public static readonly FeeType Interest = new("interest");

    public static readonly FeeType InterestReceivable = new("interest receivable");

    public static readonly FeeType LongTermCapitalGain = new("long-term capital gain");

    public static readonly FeeType LegalFee = new("legal fee");

    public static readonly FeeType ManagementFee = new("management fee");

    public static readonly FeeType MarginExpense = new("margin expense");

    public static readonly FeeType NonQualifiedDividend = new("non-qualified dividend");

    public static readonly FeeType NonResidentTax = new("non-resident tax");

    public static readonly FeeType QualifiedDividend = new("qualified dividend");

    public static readonly FeeType ReturnOfPrincipal = new("return of principal");

    public static readonly FeeType ShortTermCapitalGain = new("short-term capital gain");

    public static readonly FeeType StockDistribution = new("stock distribution");

    public static readonly FeeType Tax = new("tax");

    public static readonly FeeType TaxWithheld = new("tax withheld");

    public static readonly FeeType TransferFee = new("transfer fee");

    public static readonly FeeType TrustFee = new("trust fee");

    public static readonly FeeType UnqualifiedGain = new("unqualified gain");

    public static FeeType FromValue(string value) => FromValueCore(value);
}
