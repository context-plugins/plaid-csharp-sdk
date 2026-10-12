using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The warning code identifies a specific kind of warning.
/// <c>IDENTITY_UNAVAILABLE</c>: Unable to extract identity for the Item
/// <c>TRANSACTIONS_UNAVAILABLE</c>: Unable to extract transactions for the Item
/// <c>REPORT_DELETED</c>: Report deleted due to customer or consumer request
/// <c>DATA_UNAVAILABLE</c>: No relevant data was found for the Item
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraBankIncomeWarningCode>))]
public sealed record CraBankIncomeWarningCode : OpenStringEnum<CraBankIncomeWarningCode>
{
    private CraBankIncomeWarningCode(string value) : base(value)
    {
    }

    public static readonly CraBankIncomeWarningCode IdentityUnavailable = new("IDENTITY_UNAVAILABLE");

    public static readonly CraBankIncomeWarningCode TransactionsUnavailable = new("TRANSACTIONS_UNAVAILABLE");

    public static readonly CraBankIncomeWarningCode ReportDeleted = new("REPORT_DELETED");

    public static readonly CraBankIncomeWarningCode DataUnavailable = new("DATA_UNAVAILABLE");

    public TResult Match<TResult>(Func<TResult> onIdentityUnavailable,
        Func<TResult> onTransactionsUnavailable,
        Func<TResult> onReportDeleted,
        Func<TResult> onDataUnavailable,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == IdentityUnavailable => onIdentityUnavailable(),
            _ when this == TransactionsUnavailable => onTransactionsUnavailable(),
            _ when this == ReportDeleted => onReportDeleted(),
            _ when this == DataUnavailable => onDataUnavailable(),
            _ => otherwise(Value)
        };

    public void Match(Action onIdentityUnavailable,
        Action onTransactionsUnavailable,
        Action onReportDeleted,
        Action onDataUnavailable,
        Action<string> otherwise)
    {
        if (this == IdentityUnavailable) onIdentityUnavailable();
        else if (this == TransactionsUnavailable) onTransactionsUnavailable();
        else if (this == ReportDeleted) onReportDeleted();
        else if (this == DataUnavailable) onDataUnavailable();
        else otherwise(Value);
    }
}
