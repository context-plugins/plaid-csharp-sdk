using System;
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
public sealed record BeaconReportType : OpenStringEnum<BeaconReportType>
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

    public TResult Match<TResult>(Func<TResult> onFirstParty,
        Func<TResult> onStolen,
        Func<TResult> onSynthetic,
        Func<TResult> onAccountTakeover,
        Func<TResult> onDataBreach,
        Func<TResult> onUnknown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FirstParty => onFirstParty(),
            _ when this == Stolen => onStolen(),
            _ when this == Synthetic => onSynthetic(),
            _ when this == AccountTakeover => onAccountTakeover(),
            _ when this == DataBreach => onDataBreach(),
            _ when this == Unknown => onUnknown(),
            _ => otherwise(Value)
        };

    public void Match(Action onFirstParty,
        Action onStolen,
        Action onSynthetic,
        Action onAccountTakeover,
        Action onDataBreach,
        Action onUnknown,
        Action<string> otherwise)
    {
        if (this == FirstParty) onFirstParty();
        else if (this == Stolen) onStolen();
        else if (this == Synthetic) onSynthetic();
        else if (this == AccountTakeover) onAccountTakeover();
        else if (this == DataBreach) onDataBreach();
        else if (this == Unknown) onUnknown();
        else otherwise(Value);
    }
}
