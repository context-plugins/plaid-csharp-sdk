using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The product type for the credit profile report request.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraCreditProfileReportType>))]
public sealed record CraCreditProfileReportType : OpenStringEnum<CraCreditProfileReportType>
{
    private CraCreditProfileReportType(string value) : base(value)
    {
    }

    public static readonly CraCreditProfileReportType Qualify = new("QUALIFY");

    public TResult Match<TResult>(Func<TResult> onQualify, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Qualify => onQualify(),
            _ => otherwise(Value)
        };

    public void Match(Action onQualify, Action<string> otherwise)
    {
        if (this == Qualify) onQualify();
        else otherwise(Value);
    }
}
