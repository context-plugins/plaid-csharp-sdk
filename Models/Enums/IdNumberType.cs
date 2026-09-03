using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A globally unique and human readable ID type, specific to the country and document category. For more context on this field, see <see href="https://plaid.com/docs/identity-verification/hybrid-input-validation/#id-numbers">Input Validation Rules</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IdNumberType>))]
public sealed record IdNumberType : StringEnum<IdNumberType>
{
    private IdNumberType(string value) : base(value)
    {
    }

    public static readonly IdNumberType ArDni = new("ar_dni");

    public static readonly IdNumberType AuDriversLicense = new("au_drivers_license");

    public static readonly IdNumberType AuPassport = new("au_passport");

    public static readonly IdNumberType BrCpf = new("br_cpf");

    public static readonly IdNumberType CaSin = new("ca_sin");

    public static readonly IdNumberType ClRun = new("cl_run");

    public static readonly IdNumberType CnResidentCard = new("cn_resident_card");

    public static readonly IdNumberType CoNit = new("co_nit");

    public static readonly IdNumberType DkCpr = new("dk_cpr");

    public static readonly IdNumberType EgNationalId = new("eg_national_id");

    public static readonly IdNumberType EsDni = new("es_dni");

    public static readonly IdNumberType EsNie = new("es_nie");

    public static readonly IdNumberType HkHkid = new("hk_hkid");

    public static readonly IdNumberType InPan = new("in_pan");

    public static readonly IdNumberType InEpic = new("in_epic");

    public static readonly IdNumberType ItCf = new("it_cf");

    public static readonly IdNumberType JoCivilId = new("jo_civil_id");

    public static readonly IdNumberType JpMyNumber = new("jp_my_number");

    public static readonly IdNumberType KeHudumaNamba = new("ke_huduma_namba");

    public static readonly IdNumberType KwCivilId = new("kw_civil_id");

    public static readonly IdNumberType MxCurp = new("mx_curp");

    public static readonly IdNumberType MxRfc = new("mx_rfc");

    public static readonly IdNumberType MyNric = new("my_nric");

    public static readonly IdNumberType NgNin = new("ng_nin");

    public static readonly IdNumberType NzDriversLicense = new("nz_drivers_license");

    public static readonly IdNumberType OmCivilId = new("om_civil_id");

    public static readonly IdNumberType PhPsn = new("ph_psn");

    public static readonly IdNumberType PlPesel = new("pl_pesel");

    public static readonly IdNumberType RoCnp = new("ro_cnp");

    public static readonly IdNumberType SaNationalId = new("sa_national_id");

    public static readonly IdNumberType SePin = new("se_pin");

    public static readonly IdNumberType SgNric = new("sg_nric");

    public static readonly IdNumberType TrTcKimlik = new("tr_tc_kimlik");

    public static readonly IdNumberType UsSsn = new("us_ssn");

    public static readonly IdNumberType UsSsnLast4 = new("us_ssn_last_4");

    public static readonly IdNumberType ZaSmartId = new("za_smart_id");

    public static IdNumberType FromValue(string value) => FromValueCore(value);
}
