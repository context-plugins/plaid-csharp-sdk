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
public sealed record CraPdfAddOns : StringEnum<CraPdfAddOns>
{
    private CraPdfAddOns(string value) : base(value)
    {
    }

    public static readonly CraPdfAddOns CraIncomeInsights = new("cra_income_insights");

    public static readonly CraPdfAddOns CraPartnerInsights = new("cra_partner_insights");

    public static CraPdfAddOns FromValue(string value) => FromValueCore(value);
}
