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
/// <c>data_breach</c>: If this individual's data was compromised in a breach.
/// </para>
/// <para>
/// <c>unknown</c>: If you aren't sure who committed the fraud.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BeaconReportType>))]
public sealed record BeaconReportType : StringEnum<BeaconReportType>
{
    private BeaconReportType(string value) : base(value)
    {
    }

    public static readonly BeaconReportType FirstParty = new("first_party");

    public static readonly BeaconReportType Stolen = new("stolen");

    public static readonly BeaconReportType Synthetic = new("synthetic");

    public static readonly BeaconReportType AccountTakeover = new("account_takeover");

    public static readonly BeaconReportType DataBreach = new("data_breach");

    public static readonly BeaconReportType Unknown = new("unknown");

    public static BeaconReportType FromValue(string value) => FromValueCore(value);
}
