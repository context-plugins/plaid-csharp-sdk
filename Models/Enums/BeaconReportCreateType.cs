using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of Beacon Report.
/// <para>
/// <c>first_party</c>: If this is the same individual as the one who submitted the KYC.
/// </para>
/// <para>
/// <c>stolen</c>: If this is a different individual from the one who submitted the KYC.
/// </para>
/// <para>
/// <c>synthetic</c>: If this is an individual using fabricated information.
/// </para>
/// <para>
/// <c>account_takeover</c>: If this individual's account was compromised.
/// </para>
/// <para>
/// <c>unknown</c>: If you aren't sure who committed the fraud.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BeaconReportCreateType>))]
public sealed record BeaconReportCreateType : StringEnum<BeaconReportCreateType>
{
    private BeaconReportCreateType(string value) : base(value)
    {
    }

    public static readonly BeaconReportCreateType FirstParty = new("first_party");

    public static readonly BeaconReportCreateType Stolen = new("stolen");

    public static readonly BeaconReportCreateType Synthetic = new("synthetic");

    public static readonly BeaconReportCreateType AccountTakeover = new("account_takeover");

    public static readonly BeaconReportCreateType DataBreach = new("data_breach");

    public static readonly BeaconReportCreateType Unknown = new("unknown");

    public static BeaconReportCreateType FromValue(string value) => FromValueCore(value);
}
