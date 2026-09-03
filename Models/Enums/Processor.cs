using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The processor you are integrating with.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Processor>))]
public sealed record Processor : StringEnum<Processor>
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

    public static Processor FromValue(string value) => FromValueCore(value);
}
