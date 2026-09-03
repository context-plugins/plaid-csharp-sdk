using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates whether the email domain is listed as disposable if known. Disposable domains are often used to create email addresses that are part of a fake set of user details.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskCheckEmailDomainIsDisposable>))]
public sealed record RiskCheckEmailDomainIsDisposable : StringEnum<RiskCheckEmailDomainIsDisposable>
{
    private RiskCheckEmailDomainIsDisposable(string value) : base(value)
    {
    }

    public static readonly RiskCheckEmailDomainIsDisposable Yes = new("yes");

    public static readonly RiskCheckEmailDomainIsDisposable No = new("no");

    public static readonly RiskCheckEmailDomainIsDisposable NoData = new("no_data");

    public static RiskCheckEmailDomainIsDisposable FromValue(string value) => FromValueCore(value);
}
