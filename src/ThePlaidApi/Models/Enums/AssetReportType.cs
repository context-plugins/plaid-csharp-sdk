using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates either a Fast Asset Report, which will contain only current identity and balance information, or a Full Asset Report, which will also contain historical balance information and transaction data.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssetReportType>))]
public sealed record AssetReportType : OpenStringEnum<AssetReportType>
{
    private AssetReportType(string value) : base(value)
    {
    }

    public static readonly AssetReportType Full = new("FULL");

    public static readonly AssetReportType Fast = new("FAST");

    public TResult Match<TResult>(Func<TResult> onFull, Func<TResult> onFast, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Full => onFull(),
            _ when this == Fast => onFast(),
            _ => otherwise(Value)
        };

    public void Match(Action onFull, Action onFast, Action<string> otherwise)
    {
        if (this == Full) onFull();
        else if (this == Fast) onFast();
        else otherwise(Value);
    }
}
