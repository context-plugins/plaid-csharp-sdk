using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// SMTP-MX check to confirm the email address exists if known.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskCheckEmailIsDeliverableStatus>))]
public sealed record RiskCheckEmailIsDeliverableStatus : StringEnum<RiskCheckEmailIsDeliverableStatus>
{
    private RiskCheckEmailIsDeliverableStatus(string value) : base(value)
    {
    }

    public static readonly RiskCheckEmailIsDeliverableStatus Yes = new("yes");

    public static readonly RiskCheckEmailIsDeliverableStatus No = new("no");

    public static readonly RiskCheckEmailIsDeliverableStatus NoData = new("no_data");

    public static RiskCheckEmailIsDeliverableStatus FromValue(string value) => FromValueCore(value);
}
