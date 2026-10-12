using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of verification PDF report to fetch.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraCheckReportVerificationPdfReportType>))]
public sealed record CraCheckReportVerificationPdfReportType : OpenStringEnum<CraCheckReportVerificationPdfReportType>
{
    private CraCheckReportVerificationPdfReportType(string value) : base(value)
    {
    }

    public static readonly CraCheckReportVerificationPdfReportType Voa = new("voa");

    public static readonly CraCheckReportVerificationPdfReportType EmploymentRefresh = new("employment_refresh");

    public static readonly CraCheckReportVerificationPdfReportType Income = new("income");

    public TResult Match<TResult>(Func<TResult> onVoa,
        Func<TResult> onEmploymentRefresh,
        Func<TResult> onIncome,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Voa => onVoa(),
            _ when this == EmploymentRefresh => onEmploymentRefresh(),
            _ when this == Income => onIncome(),
            _ => otherwise(Value)
        };

    public void Match(Action onVoa, Action onEmploymentRefresh, Action onIncome, Action<string> otherwise)
    {
        if (this == Voa) onVoa();
        else if (this == EmploymentRefresh) onEmploymentRefresh();
        else if (this == Income) onIncome();
        else otherwise(Value);
    }
}
