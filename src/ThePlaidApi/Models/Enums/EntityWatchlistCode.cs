using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Shorthand identifier for a specific screening list for entities.
///  <c>AU_CON</c>: Australia Department of Foreign Affairs and Trade Consolidated List
///  <c>CA_CON</c>: Government of Canada Consolidated List of Sanctions
///  <c>EU_CON</c>: European External Action Service Consolidated List
///  <c>IZ_SOE</c>: State Owned Enterprise List
///  <c>IZ_UNC</c>: United Nations Consolidated Sanctions
///  <c>IZ_WBK</c>: World Bank Listing of Ineligible Firms and Individuals
///  <c>US_CAP</c>: US OFAC Correspondent Account or Payable-Through Account Sanctions
///  <c>US_FSE</c>: US OFAC Foreign Sanctions Evaders
///  <c>US_MBS</c>: US Non-SDN Menu-Based Sanctions
///  <c>US_SDN</c>: US OFAC Specially Designated Nationals List
///  <c>US_SSI</c>: US OFAC Sectoral Sanctions Identifications
///  <c>US_CMC</c>: US OFAC Non-SDN Chinese Military-Industrial Complex List
///  <c>US_UVL</c>: Bureau of Industry and Security Unverified List
///  <c>US_SAM</c>: US System for Award Management Exclusion List
///  <c>US_TEL</c>: US Terrorist Exclusion List
///  <c>UK_HMC</c>: Foreign, Commonwealth &amp; Development Office UK Sanctions List
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EntityWatchlistCode>))]
public sealed record EntityWatchlistCode : OpenStringEnum<EntityWatchlistCode>
{
    private EntityWatchlistCode(string value) : base(value)
    {
    }

    public static readonly EntityWatchlistCode CaCon = new("CA_CON");

    public static readonly EntityWatchlistCode EuCon = new("EU_CON");

    public static readonly EntityWatchlistCode IzSoe = new("IZ_SOE");

    public static readonly EntityWatchlistCode IzUnc = new("IZ_UNC");

    public static readonly EntityWatchlistCode IzWbk = new("IZ_WBK");

    public static readonly EntityWatchlistCode UsCap = new("US_CAP");

    public static readonly EntityWatchlistCode UsFse = new("US_FSE");

    public static readonly EntityWatchlistCode UsMbs = new("US_MBS");

    public static readonly EntityWatchlistCode UsSdn = new("US_SDN");

    public static readonly EntityWatchlistCode UsSsi = new("US_SSI");

    public static readonly EntityWatchlistCode UsCmc = new("US_CMC");

    public static readonly EntityWatchlistCode UsUvl = new("US_UVL");

    public static readonly EntityWatchlistCode UsSam = new("US_SAM");

    public static readonly EntityWatchlistCode UsTel = new("US_TEL");

    public static readonly EntityWatchlistCode AuCon = new("AU_CON");

    public static readonly EntityWatchlistCode UkHmc = new("UK_HMC");

    public TResult Match<TResult>(Func<TResult> onCaCon,
        Func<TResult> onEuCon,
        Func<TResult> onIzSoe,
        Func<TResult> onIzUnc,
        Func<TResult> onIzWbk,
        Func<TResult> onUsCap,
        Func<TResult> onUsFse,
        Func<TResult> onUsMbs,
        Func<TResult> onUsSdn,
        Func<TResult> onUsSsi,
        Func<TResult> onUsCmc,
        Func<TResult> onUsUvl,
        Func<TResult> onUsSam,
        Func<TResult> onUsTel,
        Func<TResult> onAuCon,
        Func<TResult> onUkHmc,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CaCon => onCaCon(),
            _ when this == EuCon => onEuCon(),
            _ when this == IzSoe => onIzSoe(),
            _ when this == IzUnc => onIzUnc(),
            _ when this == IzWbk => onIzWbk(),
            _ when this == UsCap => onUsCap(),
            _ when this == UsFse => onUsFse(),
            _ when this == UsMbs => onUsMbs(),
            _ when this == UsSdn => onUsSdn(),
            _ when this == UsSsi => onUsSsi(),
            _ when this == UsCmc => onUsCmc(),
            _ when this == UsUvl => onUsUvl(),
            _ when this == UsSam => onUsSam(),
            _ when this == UsTel => onUsTel(),
            _ when this == AuCon => onAuCon(),
            _ when this == UkHmc => onUkHmc(),
            _ => otherwise(Value)
        };

    public void Match(Action onCaCon,
        Action onEuCon,
        Action onIzSoe,
        Action onIzUnc,
        Action onIzWbk,
        Action onUsCap,
        Action onUsFse,
        Action onUsMbs,
        Action onUsSdn,
        Action onUsSsi,
        Action onUsCmc,
        Action onUsUvl,
        Action onUsSam,
        Action onUsTel,
        Action onAuCon,
        Action onUkHmc,
        Action<string> otherwise)
    {
        if (this == CaCon) onCaCon();
        else if (this == EuCon) onEuCon();
        else if (this == IzSoe) onIzSoe();
        else if (this == IzUnc) onIzUnc();
        else if (this == IzWbk) onIzWbk();
        else if (this == UsCap) onUsCap();
        else if (this == UsFse) onUsFse();
        else if (this == UsMbs) onUsMbs();
        else if (this == UsSdn) onUsSdn();
        else if (this == UsSsi) onUsSsi();
        else if (this == UsCmc) onUsCmc();
        else if (this == UsUvl) onUsUvl();
        else if (this == UsSam) onUsSam();
        else if (this == UsTel) onUsTel();
        else if (this == AuCon) onAuCon();
        else if (this == UkHmc) onUkHmc();
        else otherwise(Value);
    }
}
