using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The credit bureau that provided the base FICO score.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraPartnerInsightsBureau>))]
public sealed record CraPartnerInsightsBureau : StringEnum<CraPartnerInsightsBureau>
{
    private CraPartnerInsightsBureau(string value) : base(value)
    {
    }

    public static readonly CraPartnerInsightsBureau Equifax = new("EQUIFAX");

    public static readonly CraPartnerInsightsBureau Experian = new("EXPERIAN");

    public static readonly CraPartnerInsightsBureau Transunion = new("TRANSUNION");

    public static CraPartnerInsightsBureau FromValue(string value) => FromValueCore(value);
}
