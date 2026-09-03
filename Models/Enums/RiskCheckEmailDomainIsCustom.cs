using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates whether the email address domain is custom if known, i.e. a company domain and not free or disposable.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskCheckEmailDomainIsCustom>))]
public sealed record RiskCheckEmailDomainIsCustom : StringEnum<RiskCheckEmailDomainIsCustom>
{
    private RiskCheckEmailDomainIsCustom(string value) : base(value)
    {
    }

    public static readonly RiskCheckEmailDomainIsCustom Yes = new("yes");

    public static readonly RiskCheckEmailDomainIsCustom No = new("no");

    public static readonly RiskCheckEmailDomainIsCustom NoData = new("no_data");

    public static RiskCheckEmailDomainIsCustom FromValue(string value) => FromValueCore(value);
}
