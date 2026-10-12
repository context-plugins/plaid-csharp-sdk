using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The types of GSE Reports supported by the Plaid API
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GseReportType>))]
public sealed record GseReportType : OpenStringEnum<GseReportType>
{
    private GseReportType(string value) : base(value)
    {
    }

    public static readonly GseReportType Voa = new("VOA");

    public static readonly GseReportType EmploymentRefresh = new("EMPLOYMENT_REFRESH");

    public TResult Match<TResult>(Func<TResult> onVoa,
        Func<TResult> onEmploymentRefresh,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Voa => onVoa(),
            _ when this == EmploymentRefresh => onEmploymentRefresh(),
            _ => otherwise(Value)
        };

    public void Match(Action onVoa, Action onEmploymentRefresh, Action<string> otherwise)
    {
        if (this == Voa) onVoa();
        else if (this == EmploymentRefresh) onEmploymentRefresh();
        else otherwise(Value);
    }
}
