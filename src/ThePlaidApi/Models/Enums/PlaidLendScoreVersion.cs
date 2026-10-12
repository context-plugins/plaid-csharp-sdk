using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The version of the LendScore to use. Required if using LendScore.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PlaidLendScoreVersion>))]
public sealed record PlaidLendScoreVersion : OpenStringEnum<PlaidLendScoreVersion>
{
    private PlaidLendScoreVersion(string value) : base(value)
    {
    }

    public static readonly PlaidLendScoreVersion V10 = new("v1.0");

    public static readonly PlaidLendScoreVersion V20 = new("v2.0");

    public static readonly PlaidLendScoreVersion Ls1 = new("LS1");

    public TResult Match<TResult>(Func<TResult> onV10,
        Func<TResult> onV20,
        Func<TResult> onLs1,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == V10 => onV10(),
            _ when this == V20 => onV20(),
            _ when this == Ls1 => onLs1(),
            _ => otherwise(Value)
        };

    public void Match(Action onV10, Action onV20, Action onLs1, Action<string> otherwise)
    {
        if (this == V10) onV10();
        else if (this == V20) onV20();
        else if (this == Ls1) onLs1();
        else otherwise(Value);
    }
}
