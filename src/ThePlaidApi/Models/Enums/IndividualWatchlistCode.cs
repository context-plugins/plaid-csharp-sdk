using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Shorthand identifier for a specific screening list for individuals.
///  <c>AU_CON</c>: Australia Department of Foreign Affairs and Trade Consolidated List
///  <c>CA_CON</c>: Government of Canada Consolidated List of Sanctions
///  <c>EU_CON</c>: European External Action Service Consolidated List
///  <c>IZ_CIA</c>: CIA List of Chiefs of State and Cabinet Members
///  <c>IZ_IPL</c>: Interpol Red Notices for Wanted Persons List
///  <c>IZ_PEP</c>: Politically Exposed Persons List
///  <c>IZ_UNC</c>: United Nations Consolidated Sanctions
///  <c>IZ_WBK</c>: World Bank Listing of Ineligible Firms and Individuals
///  <c>UK_HMC</c>: Foreign, Commonwealth &amp; Development Office UK Sanctions List
///  <c>US_DPL</c>: Bureau of Industry and Security Denied Persons List
///  <c>US_DTC</c>: US Department of State AECA Debarred
///  <c>US_FBI</c>: US Department of Justice FBI Wanted List
///  <c>US_FSE</c>: US OFAC Foreign Sanctions Evaders
///  <c>US_ISN</c>: US Department of State Nonproliferation Sanctions
///  <c>US_MBS</c>: US Non-SDN Menu-Based Sanctions
///  <c>US_PLC</c>: US OFAC Palestinian Legislative Council
///  <c>US_SAM</c>: US System for Award Management Exclusion List
///  <c>US_SDN</c>: US OFAC Specially Designated Nationals List
///  <c>US_SSI</c>: US OFAC Sectoral Sanctions Identifications
///  <c>SG_SOF</c>: Government of Singapore Terrorists and Terrorist Entities
///  <c>TR_TWL</c>: Government of Turkey Terrorist Wanted List
///  <c>TR_DFD</c>: Government of Turkey Domestic Freezing Decisions
///  <c>TR_FOR</c>: Government of Turkey Foreign Freezing Requests
///  <c>TR_WMD</c>: Government of Turkey Weapons of Mass Destruction
///  <c>TR_CMB</c>: Government of Turkey Capital Markets Board
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IndividualWatchlistCode>))]
public sealed record IndividualWatchlistCode : OpenStringEnum<IndividualWatchlistCode>
{
    private IndividualWatchlistCode(string value) : base(value)
    {
    }

    public static readonly IndividualWatchlistCode AuCon = new("AU_CON");

    public static readonly IndividualWatchlistCode CaCon = new("CA_CON");

    public static readonly IndividualWatchlistCode EuCon = new("EU_CON");

    public static readonly IndividualWatchlistCode IzCia = new("IZ_CIA");

    public static readonly IndividualWatchlistCode IzIpl = new("IZ_IPL");

    public static readonly IndividualWatchlistCode IzPep = new("IZ_PEP");

    public static readonly IndividualWatchlistCode IzUnc = new("IZ_UNC");

    public static readonly IndividualWatchlistCode IzWbk = new("IZ_WBK");

    public static readonly IndividualWatchlistCode UkHmc = new("UK_HMC");

    public static readonly IndividualWatchlistCode UsDpl = new("US_DPL");

    public static readonly IndividualWatchlistCode UsDtc = new("US_DTC");

    public static readonly IndividualWatchlistCode UsFbi = new("US_FBI");

    public static readonly IndividualWatchlistCode UsFse = new("US_FSE");

    public static readonly IndividualWatchlistCode UsIsn = new("US_ISN");

    public static readonly IndividualWatchlistCode UsMbs = new("US_MBS");

    public static readonly IndividualWatchlistCode UsPlc = new("US_PLC");

    public static readonly IndividualWatchlistCode UsSam = new("US_SAM");

    public static readonly IndividualWatchlistCode UsSdn = new("US_SDN");

    public static readonly IndividualWatchlistCode UsSsi = new("US_SSI");

    public static readonly IndividualWatchlistCode SgSof = new("SG_SOF");

    public static readonly IndividualWatchlistCode TrTwl = new("TR_TWL");

    public static readonly IndividualWatchlistCode TrDfd = new("TR_DFD");

    public static readonly IndividualWatchlistCode TrFor = new("TR_FOR");

    public static readonly IndividualWatchlistCode TrWmd = new("TR_WMD");

    public static readonly IndividualWatchlistCode TrCmb = new("TR_CMB");

    public TResult Match<TResult>(Func<TResult> onAuCon,
        Func<TResult> onCaCon,
        Func<TResult> onEuCon,
        Func<TResult> onIzCia,
        Func<TResult> onIzIpl,
        Func<TResult> onIzPep,
        Func<TResult> onIzUnc,
        Func<TResult> onIzWbk,
        Func<TResult> onUkHmc,
        Func<TResult> onUsDpl,
        Func<TResult> onUsDtc,
        Func<TResult> onUsFbi,
        Func<TResult> onUsFse,
        Func<TResult> onUsIsn,
        Func<TResult> onUsMbs,
        Func<TResult> onUsPlc,
        Func<TResult> onUsSam,
        Func<TResult> onUsSdn,
        Func<TResult> onUsSsi,
        Func<TResult> onSgSof,
        Func<TResult> onTrTwl,
        Func<TResult> onTrDfd,
        Func<TResult> onTrFor,
        Func<TResult> onTrWmd,
        Func<TResult> onTrCmb,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AuCon => onAuCon(),
            _ when this == CaCon => onCaCon(),
            _ when this == EuCon => onEuCon(),
            _ when this == IzCia => onIzCia(),
            _ when this == IzIpl => onIzIpl(),
            _ when this == IzPep => onIzPep(),
            _ when this == IzUnc => onIzUnc(),
            _ when this == IzWbk => onIzWbk(),
            _ when this == UkHmc => onUkHmc(),
            _ when this == UsDpl => onUsDpl(),
            _ when this == UsDtc => onUsDtc(),
            _ when this == UsFbi => onUsFbi(),
            _ when this == UsFse => onUsFse(),
            _ when this == UsIsn => onUsIsn(),
            _ when this == UsMbs => onUsMbs(),
            _ when this == UsPlc => onUsPlc(),
            _ when this == UsSam => onUsSam(),
            _ when this == UsSdn => onUsSdn(),
            _ when this == UsSsi => onUsSsi(),
            _ when this == SgSof => onSgSof(),
            _ when this == TrTwl => onTrTwl(),
            _ when this == TrDfd => onTrDfd(),
            _ when this == TrFor => onTrFor(),
            _ when this == TrWmd => onTrWmd(),
            _ when this == TrCmb => onTrCmb(),
            _ => otherwise(Value)
        };

    public void Match(Action onAuCon,
        Action onCaCon,
        Action onEuCon,
        Action onIzCia,
        Action onIzIpl,
        Action onIzPep,
        Action onIzUnc,
        Action onIzWbk,
        Action onUkHmc,
        Action onUsDpl,
        Action onUsDtc,
        Action onUsFbi,
        Action onUsFse,
        Action onUsIsn,
        Action onUsMbs,
        Action onUsPlc,
        Action onUsSam,
        Action onUsSdn,
        Action onUsSsi,
        Action onSgSof,
        Action onTrTwl,
        Action onTrDfd,
        Action onTrFor,
        Action onTrWmd,
        Action onTrCmb,
        Action<string> otherwise)
    {
        if (this == AuCon) onAuCon();
        else if (this == CaCon) onCaCon();
        else if (this == EuCon) onEuCon();
        else if (this == IzCia) onIzCia();
        else if (this == IzIpl) onIzIpl();
        else if (this == IzPep) onIzPep();
        else if (this == IzUnc) onIzUnc();
        else if (this == IzWbk) onIzWbk();
        else if (this == UkHmc) onUkHmc();
        else if (this == UsDpl) onUsDpl();
        else if (this == UsDtc) onUsDtc();
        else if (this == UsFbi) onUsFbi();
        else if (this == UsFse) onUsFse();
        else if (this == UsIsn) onUsIsn();
        else if (this == UsMbs) onUsMbs();
        else if (this == UsPlc) onUsPlc();
        else if (this == UsSam) onUsSam();
        else if (this == UsSdn) onUsSdn();
        else if (this == UsSsi) onUsSsi();
        else if (this == SgSof) onSgSof();
        else if (this == TrTwl) onTrTwl();
        else if (this == TrDfd) onTrDfd();
        else if (this == TrFor) onTrFor();
        else if (this == TrWmd) onTrWmd();
        else if (this == TrCmb) onTrCmb();
        else otherwise(Value);
    }
}
