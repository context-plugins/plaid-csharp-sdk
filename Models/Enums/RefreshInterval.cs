using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// How frequently data for subscription products like Investments, Transactions, and Liabilities, is being refreshed, relative to the institution's normal scheduling. The <c>refresh_interval</c> may be <c>DELAYED</c> or <c>STOPPED</c> even when the success rate is high.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RefreshInterval>))]
public sealed record RefreshInterval : StringEnum<RefreshInterval>
{
    private RefreshInterval(string value) : base(value)
    {
    }

    public static readonly RefreshInterval Normal = new("NORMAL");

    public static readonly RefreshInterval Delayed = new("DELAYED");

    public static readonly RefreshInterval Stopped = new("STOPPED");

    public static RefreshInterval FromValue(string value) => FromValueCore(value);
}
