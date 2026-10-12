using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A globally unique and human readable ID type, specific to the country and document category. For more context on this field, see <see href="https://plaid.com/docs/identity-verification/hybrid-input-validation/#id-numbers">Input Validation Rules</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IdNumberType>))]
public sealed record IdNumberType : OpenStringEnum<IdNumberType>
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

    public TResult Match<TResult>(Func<TResult> onArDni,
        Func<TResult> onAuDriversLicense,
        Func<TResult> onAuPassport,
        Func<TResult> onBrCpf,
        Func<TResult> onCaSin,
        Func<TResult> onClRun,
        Func<TResult> onCnResidentCard,
        Func<TResult> onCoNit,
        Func<TResult> onDkCpr,
        Func<TResult> onEgNationalId,
        Func<TResult> onEsDni,
        Func<TResult> onEsNie,
        Func<TResult> onHkHkid,
        Func<TResult> onInPan,
        Func<TResult> onInEpic,
        Func<TResult> onItCf,
        Func<TResult> onJoCivilId,
        Func<TResult> onJpMyNumber,
        Func<TResult> onKeHudumaNamba,
        Func<TResult> onKwCivilId,
        Func<TResult> onMxCurp,
        Func<TResult> onMxRfc,
        Func<TResult> onMyNric,
        Func<TResult> onNgNin,
        Func<TResult> onNzDriversLicense,
        Func<TResult> onOmCivilId,
        Func<TResult> onPhPsn,
        Func<TResult> onPlPesel,
        Func<TResult> onRoCnp,
        Func<TResult> onSaNationalId,
        Func<TResult> onSePin,
        Func<TResult> onSgNric,
        Func<TResult> onTrTcKimlik,
        Func<TResult> onUsSsn,
        Func<TResult> onUsSsnLast4,
        Func<TResult> onZaSmartId,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ArDni => onArDni(),
            _ when this == AuDriversLicense => onAuDriversLicense(),
            _ when this == AuPassport => onAuPassport(),
            _ when this == BrCpf => onBrCpf(),
            _ when this == CaSin => onCaSin(),
            _ when this == ClRun => onClRun(),
            _ when this == CnResidentCard => onCnResidentCard(),
            _ when this == CoNit => onCoNit(),
            _ when this == DkCpr => onDkCpr(),
            _ when this == EgNationalId => onEgNationalId(),
            _ when this == EsDni => onEsDni(),
            _ when this == EsNie => onEsNie(),
            _ when this == HkHkid => onHkHkid(),
            _ when this == InPan => onInPan(),
            _ when this == InEpic => onInEpic(),
            _ when this == ItCf => onItCf(),
            _ when this == JoCivilId => onJoCivilId(),
            _ when this == JpMyNumber => onJpMyNumber(),
            _ when this == KeHudumaNamba => onKeHudumaNamba(),
            _ when this == KwCivilId => onKwCivilId(),
            _ when this == MxCurp => onMxCurp(),
            _ when this == MxRfc => onMxRfc(),
            _ when this == MyNric => onMyNric(),
            _ when this == NgNin => onNgNin(),
            _ when this == NzDriversLicense => onNzDriversLicense(),
            _ when this == OmCivilId => onOmCivilId(),
            _ when this == PhPsn => onPhPsn(),
            _ when this == PlPesel => onPlPesel(),
            _ when this == RoCnp => onRoCnp(),
            _ when this == SaNationalId => onSaNationalId(),
            _ when this == SePin => onSePin(),
            _ when this == SgNric => onSgNric(),
            _ when this == TrTcKimlik => onTrTcKimlik(),
            _ when this == UsSsn => onUsSsn(),
            _ when this == UsSsnLast4 => onUsSsnLast4(),
            _ when this == ZaSmartId => onZaSmartId(),
            _ => otherwise(Value)
        };

    public void Match(Action onArDni,
        Action onAuDriversLicense,
        Action onAuPassport,
        Action onBrCpf,
        Action onCaSin,
        Action onClRun,
        Action onCnResidentCard,
        Action onCoNit,
        Action onDkCpr,
        Action onEgNationalId,
        Action onEsDni,
        Action onEsNie,
        Action onHkHkid,
        Action onInPan,
        Action onInEpic,
        Action onItCf,
        Action onJoCivilId,
        Action onJpMyNumber,
        Action onKeHudumaNamba,
        Action onKwCivilId,
        Action onMxCurp,
        Action onMxRfc,
        Action onMyNric,
        Action onNgNin,
        Action onNzDriversLicense,
        Action onOmCivilId,
        Action onPhPsn,
        Action onPlPesel,
        Action onRoCnp,
        Action onSaNationalId,
        Action onSePin,
        Action onSgNric,
        Action onTrTcKimlik,
        Action onUsSsn,
        Action onUsSsnLast4,
        Action onZaSmartId,
        Action<string> otherwise)
    {
        if (this == ArDni) onArDni();
        else if (this == AuDriversLicense) onAuDriversLicense();
        else if (this == AuPassport) onAuPassport();
        else if (this == BrCpf) onBrCpf();
        else if (this == CaSin) onCaSin();
        else if (this == ClRun) onClRun();
        else if (this == CnResidentCard) onCnResidentCard();
        else if (this == CoNit) onCoNit();
        else if (this == DkCpr) onDkCpr();
        else if (this == EgNationalId) onEgNationalId();
        else if (this == EsDni) onEsDni();
        else if (this == EsNie) onEsNie();
        else if (this == HkHkid) onHkHkid();
        else if (this == InPan) onInPan();
        else if (this == InEpic) onInEpic();
        else if (this == ItCf) onItCf();
        else if (this == JoCivilId) onJoCivilId();
        else if (this == JpMyNumber) onJpMyNumber();
        else if (this == KeHudumaNamba) onKeHudumaNamba();
        else if (this == KwCivilId) onKwCivilId();
        else if (this == MxCurp) onMxCurp();
        else if (this == MxRfc) onMxRfc();
        else if (this == MyNric) onMyNric();
        else if (this == NgNin) onNgNin();
        else if (this == NzDriversLicense) onNzDriversLicense();
        else if (this == OmCivilId) onOmCivilId();
        else if (this == PhPsn) onPhPsn();
        else if (this == PlPesel) onPlPesel();
        else if (this == RoCnp) onRoCnp();
        else if (this == SaNationalId) onSaNationalId();
        else if (this == SePin) onSePin();
        else if (this == SgNric) onSgNric();
        else if (this == TrTcKimlik) onTrTcKimlik();
        else if (this == UsSsn) onUsSsn();
        else if (this == UsSsnLast4) onUsSsnLast4();
        else if (this == ZaSmartId) onZaSmartId();
        else otherwise(Value);
    }
}
