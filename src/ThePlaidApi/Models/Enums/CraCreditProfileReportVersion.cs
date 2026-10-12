using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The version of the credit profile report to retrieve.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraCreditProfileReportVersion>))]
public sealed record CraCreditProfileReportVersion : OpenStringEnum<CraCreditProfileReportVersion>
{
    private CraCreditProfileReportVersion(string value) : base(value)
    {
    }

    public static readonly CraCreditProfileReportVersion V1 = new("v1");

    public TResult Match<TResult>(Func<TResult> onV1, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == V1 => onV1(),
            _ => otherwise(Value)
        };

    public void Match(Action onV1, Action<string> otherwise)
    {
        if (this == V1) onV1();
        else otherwise(Value);
    }
}
