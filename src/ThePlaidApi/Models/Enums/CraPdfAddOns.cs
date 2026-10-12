using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A list of add-ons that can be included in the PDF.
/// <para>
/// <c>cra_income_insights</c>: Include Income Insights report in the PDF.
/// <c>cra_partner_insights</c>: Include Partner Insights report in the PDF.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraPdfAddOns>))]
public sealed record CraPdfAddOns : OpenStringEnum<CraPdfAddOns>
{
    private CraPdfAddOns(string value) : base(value)
    {
    }

    public static readonly CraPdfAddOns CraIncomeInsights = new("cra_income_insights");

    public static readonly CraPdfAddOns CraPartnerInsights = new("cra_partner_insights");

    public TResult Match<TResult>(Func<TResult> onCraIncomeInsights,
        Func<TResult> onCraPartnerInsights,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CraIncomeInsights => onCraIncomeInsights(),
            _ when this == CraPartnerInsights => onCraPartnerInsights(),
            _ => otherwise(Value)
        };

    public void Match(Action onCraIncomeInsights, Action onCraPartnerInsights, Action<string> otherwise)
    {
        if (this == CraIncomeInsights) onCraIncomeInsights();
        else if (this == CraPartnerInsights) onCraPartnerInsights();
        else otherwise(Value);
    }
}
