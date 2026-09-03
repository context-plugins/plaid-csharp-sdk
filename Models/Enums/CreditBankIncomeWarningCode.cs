using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The warning code identifies a specific kind of warning.
/// <c>IDENTITY_UNAVAILABLE</c>: Unable to extract identity for the Item
/// <c>TRANSACTIONS_UNAVAILABLE</c>: Unable to extract transactions for the Item
/// <c>ITEM_UNAPPROVED</c>: User exited flow before giving permission to share data for the Item
/// <c>REPORT_DELETED</c>: Report deleted due to customer or consumer request
/// <c>DATA_UNAVAILABLE</c>: No relevant data was found for the Item
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreditBankIncomeWarningCode>))]
public sealed record CreditBankIncomeWarningCode : StringEnum<CreditBankIncomeWarningCode>
{
    private CreditBankIncomeWarningCode(string value) : base(value)
    {
    }

    public static readonly CreditBankIncomeWarningCode IdentityUnavailable = new("IDENTITY_UNAVAILABLE");

    public static readonly CreditBankIncomeWarningCode TransactionsUnavailable = new("TRANSACTIONS_UNAVAILABLE");

    public static readonly CreditBankIncomeWarningCode ItemUnapproved = new("ITEM_UNAPPROVED");

    public static readonly CreditBankIncomeWarningCode ReportDeleted = new("REPORT_DELETED");

    public static readonly CreditBankIncomeWarningCode DataUnavailable = new("DATA_UNAVAILABLE");

    public static CreditBankIncomeWarningCode FromValue(string value) => FromValueCore(value);
}
