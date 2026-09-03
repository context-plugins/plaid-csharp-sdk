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
public sealed record EntityWatchlistCode : StringEnum<EntityWatchlistCode>
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

    public static EntityWatchlistCode FromValue(string value) => FromValueCore(value);
}
