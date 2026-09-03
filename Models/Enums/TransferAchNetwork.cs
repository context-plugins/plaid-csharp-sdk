using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The ACH networks used for the funds flow.
/// <para>
/// For requests submitted as either <c>ach</c> or <c>same-day-ach</c> the cutoff for Same Day ACH is 3:00 PM Eastern Time and the cutoff for Standard ACH transfers is 8:30 PM Eastern Time. It is recommended to submit a request at least 15 minutes before the cutoff time in order to ensure that it will be processed before the cutoff. Any request that is indicated as <c>same-day-ach</c> and that misses the Same Day ACH cutoff, but is submitted in time for the Standard ACH cutoff, will be sent over Standard ACH rails and will not incur same-day charges.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferAchNetwork>))]
public sealed record TransferAchNetwork : StringEnum<TransferAchNetwork>
{
    private TransferAchNetwork(string value) : base(value)
    {
    }

    public static readonly TransferAchNetwork Ach = new("ach");

    public static readonly TransferAchNetwork SameDayAch = new("same-day-ach");

    public static TransferAchNetwork FromValue(string value) => FromValueCore(value);
}
