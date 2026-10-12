using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The report type. It can be <c>asset</c>. Income report types are not yet supported.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ReportType>))]
public sealed record ReportType : OpenStringEnum<ReportType>
{
    private ReportType(string value) : base(value)
    {
    }

    public static readonly ReportType Asset = new("asset");

    public TResult Match<TResult>(Func<TResult> onAsset, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Asset => onAsset(),
            _ => otherwise(Value)
        };

    public void Match(Action onAsset, Action<string> otherwise)
    {
        if (this == Asset) onAsset();
        else otherwise(Value);
    }
}
