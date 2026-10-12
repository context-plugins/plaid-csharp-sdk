using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Type of home lending report.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraCheckReportVerificationGetReportType>))]
public sealed record CraCheckReportVerificationGetReportType : OpenStringEnum<CraCheckReportVerificationGetReportType>
{
    private CraCheckReportVerificationGetReportType(string value) : base(value)
    {
    }

    public static readonly CraCheckReportVerificationGetReportType Voa = new("VOA");

    public static readonly CraCheckReportVerificationGetReportType EmploymentRefresh = new("EMPLOYMENT_REFRESH");

    public static readonly CraCheckReportVerificationGetReportType Income = new("INCOME");

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
