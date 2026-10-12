using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The processor you are integrating with.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Processor>))]
public sealed record Processor : OpenStringEnum<Processor>
{
    private Processor(string value) : base(value)
    {
    }

    public static readonly Processor Dwolla = new("dwolla");

    public static readonly Processor Galileo = new("galileo");

    public static readonly Processor ModernTreasury = new("modern_treasury");

    public static readonly Processor Ocrolus = new("ocrolus");

    public static readonly Processor Vesta = new("vesta");

    public static readonly Processor Drivewealth = new("drivewealth");

    public static readonly Processor Vopay = new("vopay");

    public static readonly Processor Achq = new("achq");

    public static readonly Processor Check = new("check");

    public static readonly Processor Checkbook = new("checkbook");

    public static readonly Processor Circle = new("circle");

    public static readonly Processor SilaMoney = new("sila_money");

    public static readonly Processor Rize = new("rize");

    public static readonly Processor SvbApi = new("svb_api");

    public static readonly Processor Unit = new("unit");

    public static readonly Processor Wyre = new("wyre");

    public static readonly Processor Lithic = new("lithic");

    public static readonly Processor Alpaca = new("alpaca");

    public static readonly Processor Astra = new("astra");

    public static readonly Processor Moov = new("moov");

    public static readonly Processor TreasuryPrime = new("treasury_prime");

    public static readonly Processor Marqeta = new("marqeta");

    public static readonly Processor Checkout = new("checkout");

    public static readonly Processor Solid = new("solid");

    public static readonly Processor Highnote = new("highnote");

    public static readonly Processor Gemini = new("gemini");

    public static readonly Processor ApexClearing = new("apex_clearing");

    public static readonly Processor Gusto = new("gusto");

    public static readonly Processor Adyen = new("adyen");

    public static readonly Processor Atomic = new("atomic");

    public static readonly Processor I2C = new("i2c");

    public static readonly Processor Wepay = new("wepay");

    public static readonly Processor Riskified = new("riskified");

    public static readonly Processor Utb = new("utb");

    public static readonly Processor AdpRoll = new("adp_roll");

    public static readonly Processor FortressTrust = new("fortress_trust");

    public static readonly Processor Bond = new("bond");

    public static readonly Processor Bakkt = new("bakkt");

    public static readonly Processor Teal = new("teal");

    public static readonly Processor ZeroHash = new("zero_hash");

    public static readonly Processor TabaPay = new("taba_pay");

    public static readonly Processor Knot = new("knot");

    public static readonly Processor Sardine = new("sardine");

    public static readonly Processor Alloy = new("alloy");

    public static readonly Processor Finix = new("finix");

    public static readonly Processor Nuvei = new("nuvei");

    public static readonly Processor Layer = new("layer");

    public static readonly Processor Boom = new("boom");

    public static readonly Processor Paynote = new("paynote");

    public static readonly Processor Stake = new("stake");

    public static readonly Processor Wedbush = new("wedbush");

    public static readonly Processor Esusu = new("esusu");

    public static readonly Processor Ansa = new("ansa");

    public static readonly Processor Scribeup = new("scribeup");

    public static readonly Processor Straddle = new("straddle");

    public static readonly Processor Loanpro = new("loanpro");

    public static readonly Processor BloomCredit = new("bloom_credit");

    public static readonly Processor Sfox = new("sfox");

    public static readonly Processor Brale = new("brale");

    public static readonly Processor Parafin = new("parafin");

    public static readonly Processor Cardless = new("cardless");

    public static readonly Processor OpenLedger = new("open_ledger");

    public static readonly Processor Valon = new("valon");

    public static readonly Processor Gainbridge = new("gainbridge");

    public static readonly Processor Cardlytics = new("cardlytics");

    public static readonly Processor Pinwheel = new("pinwheel");

    public static readonly Processor ThreadBank = new("thread_bank");

    public static readonly Processor Array = new("array");

    public static readonly Processor Fiant = new("fiant");

    public static readonly Processor Oatfi = new("oatfi");

    public static readonly Processor Curinos = new("curinos");

    public static readonly Processor Frame = new("frame");

    public static readonly Processor Interchecks = new("interchecks");

    public static readonly Processor Interchange = new("interchange");

    public static readonly Processor Atomicfi = new("atomicfi");

    public static readonly Processor Pay = new("pay");

    public static readonly Processor Natural = new("natural");

    public static readonly Processor Kanmon = new("kanmon");

    public static readonly Processor Kick = new("kick");

    public static readonly Processor Increase = new("increase");

    public TResult Match<TResult>(Func<TResult> onDwolla,
        Func<TResult> onGalileo,
        Func<TResult> onModernTreasury,
        Func<TResult> onOcrolus,
        Func<TResult> onVesta,
        Func<TResult> onDrivewealth,
        Func<TResult> onVopay,
        Func<TResult> onAchq,
        Func<TResult> onCheck,
        Func<TResult> onCheckbook,
        Func<TResult> onCircle,
        Func<TResult> onSilaMoney,
        Func<TResult> onRize,
        Func<TResult> onSvbApi,
        Func<TResult> onUnit,
        Func<TResult> onWyre,
        Func<TResult> onLithic,
        Func<TResult> onAlpaca,
        Func<TResult> onAstra,
        Func<TResult> onMoov,
        Func<TResult> onTreasuryPrime,
        Func<TResult> onMarqeta,
        Func<TResult> onCheckout,
        Func<TResult> onSolid,
        Func<TResult> onHighnote,
        Func<TResult> onGemini,
        Func<TResult> onApexClearing,
        Func<TResult> onGusto,
        Func<TResult> onAdyen,
        Func<TResult> onAtomic,
        Func<TResult> onI2C,
        Func<TResult> onWepay,
        Func<TResult> onRiskified,
        Func<TResult> onUtb,
        Func<TResult> onAdpRoll,
        Func<TResult> onFortressTrust,
        Func<TResult> onBond,
        Func<TResult> onBakkt,
        Func<TResult> onTeal,
        Func<TResult> onZeroHash,
        Func<TResult> onTabaPay,
        Func<TResult> onKnot,
        Func<TResult> onSardine,
        Func<TResult> onAlloy,
        Func<TResult> onFinix,
        Func<TResult> onNuvei,
        Func<TResult> onLayer,
        Func<TResult> onBoom,
        Func<TResult> onPaynote,
        Func<TResult> onStake,
        Func<TResult> onWedbush,
        Func<TResult> onEsusu,
        Func<TResult> onAnsa,
        Func<TResult> onScribeup,
        Func<TResult> onStraddle,
        Func<TResult> onLoanpro,
        Func<TResult> onBloomCredit,
        Func<TResult> onSfox,
        Func<TResult> onBrale,
        Func<TResult> onParafin,
        Func<TResult> onCardless,
        Func<TResult> onOpenLedger,
        Func<TResult> onValon,
        Func<TResult> onGainbridge,
        Func<TResult> onCardlytics,
        Func<TResult> onPinwheel,
        Func<TResult> onThreadBank,
        Func<TResult> onArray,
        Func<TResult> onFiant,
        Func<TResult> onOatfi,
        Func<TResult> onCurinos,
        Func<TResult> onFrame,
        Func<TResult> onInterchecks,
        Func<TResult> onInterchange,
        Func<TResult> onAtomicfi,
        Func<TResult> onPay,
        Func<TResult> onNatural,
        Func<TResult> onKanmon,
        Func<TResult> onKick,
        Func<TResult> onIncrease,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Dwolla => onDwolla(),
            _ when this == Galileo => onGalileo(),
            _ when this == ModernTreasury => onModernTreasury(),
            _ when this == Ocrolus => onOcrolus(),
            _ when this == Vesta => onVesta(),
            _ when this == Drivewealth => onDrivewealth(),
            _ when this == Vopay => onVopay(),
            _ when this == Achq => onAchq(),
            _ when this == Check => onCheck(),
            _ when this == Checkbook => onCheckbook(),
            _ when this == Circle => onCircle(),
            _ when this == SilaMoney => onSilaMoney(),
            _ when this == Rize => onRize(),
            _ when this == SvbApi => onSvbApi(),
            _ when this == Unit => onUnit(),
            _ when this == Wyre => onWyre(),
            _ when this == Lithic => onLithic(),
            _ when this == Alpaca => onAlpaca(),
            _ when this == Astra => onAstra(),
            _ when this == Moov => onMoov(),
            _ when this == TreasuryPrime => onTreasuryPrime(),
            _ when this == Marqeta => onMarqeta(),
            _ when this == Checkout => onCheckout(),
            _ when this == Solid => onSolid(),
            _ when this == Highnote => onHighnote(),
            _ when this == Gemini => onGemini(),
            _ when this == ApexClearing => onApexClearing(),
            _ when this == Gusto => onGusto(),
            _ when this == Adyen => onAdyen(),
            _ when this == Atomic => onAtomic(),
            _ when this == I2C => onI2C(),
            _ when this == Wepay => onWepay(),
            _ when this == Riskified => onRiskified(),
            _ when this == Utb => onUtb(),
            _ when this == AdpRoll => onAdpRoll(),
            _ when this == FortressTrust => onFortressTrust(),
            _ when this == Bond => onBond(),
            _ when this == Bakkt => onBakkt(),
            _ when this == Teal => onTeal(),
            _ when this == ZeroHash => onZeroHash(),
            _ when this == TabaPay => onTabaPay(),
            _ when this == Knot => onKnot(),
            _ when this == Sardine => onSardine(),
            _ when this == Alloy => onAlloy(),
            _ when this == Finix => onFinix(),
            _ when this == Nuvei => onNuvei(),
            _ when this == Layer => onLayer(),
            _ when this == Boom => onBoom(),
            _ when this == Paynote => onPaynote(),
            _ when this == Stake => onStake(),
            _ when this == Wedbush => onWedbush(),
            _ when this == Esusu => onEsusu(),
            _ when this == Ansa => onAnsa(),
            _ when this == Scribeup => onScribeup(),
            _ when this == Straddle => onStraddle(),
            _ when this == Loanpro => onLoanpro(),
            _ when this == BloomCredit => onBloomCredit(),
            _ when this == Sfox => onSfox(),
            _ when this == Brale => onBrale(),
            _ when this == Parafin => onParafin(),
            _ when this == Cardless => onCardless(),
            _ when this == OpenLedger => onOpenLedger(),
            _ when this == Valon => onValon(),
            _ when this == Gainbridge => onGainbridge(),
            _ when this == Cardlytics => onCardlytics(),
            _ when this == Pinwheel => onPinwheel(),
            _ when this == ThreadBank => onThreadBank(),
            _ when this == Array => onArray(),
            _ when this == Fiant => onFiant(),
            _ when this == Oatfi => onOatfi(),
            _ when this == Curinos => onCurinos(),
            _ when this == Frame => onFrame(),
            _ when this == Interchecks => onInterchecks(),
            _ when this == Interchange => onInterchange(),
            _ when this == Atomicfi => onAtomicfi(),
            _ when this == Pay => onPay(),
            _ when this == Natural => onNatural(),
            _ when this == Kanmon => onKanmon(),
            _ when this == Kick => onKick(),
            _ when this == Increase => onIncrease(),
            _ => otherwise(Value)
        };

    public void Match(Action onDwolla,
        Action onGalileo,
        Action onModernTreasury,
        Action onOcrolus,
        Action onVesta,
        Action onDrivewealth,
        Action onVopay,
        Action onAchq,
        Action onCheck,
        Action onCheckbook,
        Action onCircle,
        Action onSilaMoney,
        Action onRize,
        Action onSvbApi,
        Action onUnit,
        Action onWyre,
        Action onLithic,
        Action onAlpaca,
        Action onAstra,
        Action onMoov,
        Action onTreasuryPrime,
        Action onMarqeta,
        Action onCheckout,
        Action onSolid,
        Action onHighnote,
        Action onGemini,
        Action onApexClearing,
        Action onGusto,
        Action onAdyen,
        Action onAtomic,
        Action onI2C,
        Action onWepay,
        Action onRiskified,
        Action onUtb,
        Action onAdpRoll,
        Action onFortressTrust,
        Action onBond,
        Action onBakkt,
        Action onTeal,
        Action onZeroHash,
        Action onTabaPay,
        Action onKnot,
        Action onSardine,
        Action onAlloy,
        Action onFinix,
        Action onNuvei,
        Action onLayer,
        Action onBoom,
        Action onPaynote,
        Action onStake,
        Action onWedbush,
        Action onEsusu,
        Action onAnsa,
        Action onScribeup,
        Action onStraddle,
        Action onLoanpro,
        Action onBloomCredit,
        Action onSfox,
        Action onBrale,
        Action onParafin,
        Action onCardless,
        Action onOpenLedger,
        Action onValon,
        Action onGainbridge,
        Action onCardlytics,
        Action onPinwheel,
        Action onThreadBank,
        Action onArray,
        Action onFiant,
        Action onOatfi,
        Action onCurinos,
        Action onFrame,
        Action onInterchecks,
        Action onInterchange,
        Action onAtomicfi,
        Action onPay,
        Action onNatural,
        Action onKanmon,
        Action onKick,
        Action onIncrease,
        Action<string> otherwise)
    {
        if (this == Dwolla) onDwolla();
        else if (this == Galileo) onGalileo();
        else if (this == ModernTreasury) onModernTreasury();
        else if (this == Ocrolus) onOcrolus();
        else if (this == Vesta) onVesta();
        else if (this == Drivewealth) onDrivewealth();
        else if (this == Vopay) onVopay();
        else if (this == Achq) onAchq();
        else if (this == Check) onCheck();
        else if (this == Checkbook) onCheckbook();
        else if (this == Circle) onCircle();
        else if (this == SilaMoney) onSilaMoney();
        else if (this == Rize) onRize();
        else if (this == SvbApi) onSvbApi();
        else if (this == Unit) onUnit();
        else if (this == Wyre) onWyre();
        else if (this == Lithic) onLithic();
        else if (this == Alpaca) onAlpaca();
        else if (this == Astra) onAstra();
        else if (this == Moov) onMoov();
        else if (this == TreasuryPrime) onTreasuryPrime();
        else if (this == Marqeta) onMarqeta();
        else if (this == Checkout) onCheckout();
        else if (this == Solid) onSolid();
        else if (this == Highnote) onHighnote();
        else if (this == Gemini) onGemini();
        else if (this == ApexClearing) onApexClearing();
        else if (this == Gusto) onGusto();
        else if (this == Adyen) onAdyen();
        else if (this == Atomic) onAtomic();
        else if (this == I2C) onI2C();
        else if (this == Wepay) onWepay();
        else if (this == Riskified) onRiskified();
        else if (this == Utb) onUtb();
        else if (this == AdpRoll) onAdpRoll();
        else if (this == FortressTrust) onFortressTrust();
        else if (this == Bond) onBond();
        else if (this == Bakkt) onBakkt();
        else if (this == Teal) onTeal();
        else if (this == ZeroHash) onZeroHash();
        else if (this == TabaPay) onTabaPay();
        else if (this == Knot) onKnot();
        else if (this == Sardine) onSardine();
        else if (this == Alloy) onAlloy();
        else if (this == Finix) onFinix();
        else if (this == Nuvei) onNuvei();
        else if (this == Layer) onLayer();
        else if (this == Boom) onBoom();
        else if (this == Paynote) onPaynote();
        else if (this == Stake) onStake();
        else if (this == Wedbush) onWedbush();
        else if (this == Esusu) onEsusu();
        else if (this == Ansa) onAnsa();
        else if (this == Scribeup) onScribeup();
        else if (this == Straddle) onStraddle();
        else if (this == Loanpro) onLoanpro();
        else if (this == BloomCredit) onBloomCredit();
        else if (this == Sfox) onSfox();
        else if (this == Brale) onBrale();
        else if (this == Parafin) onParafin();
        else if (this == Cardless) onCardless();
        else if (this == OpenLedger) onOpenLedger();
        else if (this == Valon) onValon();
        else if (this == Gainbridge) onGainbridge();
        else if (this == Cardlytics) onCardlytics();
        else if (this == Pinwheel) onPinwheel();
        else if (this == ThreadBank) onThreadBank();
        else if (this == Array) onArray();
        else if (this == Fiant) onFiant();
        else if (this == Oatfi) onOatfi();
        else if (this == Curinos) onCurinos();
        else if (this == Frame) onFrame();
        else if (this == Interchecks) onInterchecks();
        else if (this == Interchange) onInterchange();
        else if (this == Atomicfi) onAtomicfi();
        else if (this == Pay) onPay();
        else if (this == Natural) onNatural();
        else if (this == Kanmon) onKanmon();
        else if (this == Kick) onKick();
        else if (this == Increase) onIncrease();
        else otherwise(Value);
    }
}
