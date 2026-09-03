using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates whether the email address domain is a free provider such as Gmail or Hotmail if known.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskCheckEmailDomainIsFreeProvider>))]
public sealed record RiskCheckEmailDomainIsFreeProvider : StringEnum<RiskCheckEmailDomainIsFreeProvider>
{
    private RiskCheckEmailDomainIsFreeProvider(string value) : base(value)
    {
    }

    public static readonly RiskCheckEmailDomainIsFreeProvider Yes = new("yes");

    public static readonly RiskCheckEmailDomainIsFreeProvider No = new("no");

    public static readonly RiskCheckEmailDomainIsFreeProvider NoData = new("no_data");

    public static RiskCheckEmailDomainIsFreeProvider FromValue(string value) => FromValueCore(value);
}
