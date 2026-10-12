using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The version of Income Insights to use. This value is not shared across API calls for the same resource. If it is omitted from a request, the default version is used, even if a version was set in an earlier call such as <c>/link/token/create</c> or <c>/cra/check_report/create</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IncomeInsightsVersion>))]
public sealed record IncomeInsightsVersion : OpenStringEnum<IncomeInsightsVersion>
{
    private IncomeInsightsVersion(string value) : base(value)
    {
    }

    public static readonly IncomeInsightsVersion Ii2 = new("II2");

    public TResult Match<TResult>(Func<TResult> onIi2, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ii2 => onIi2(),
            _ => otherwise(Value)
        };

    public void Match(Action onIi2, Action<string> otherwise)
    {
        if (this == Ii2) onIi2();
        else otherwise(Value);
    }
}
