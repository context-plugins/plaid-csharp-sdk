using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// List of unofficial currency codes
/// </summary>
[JsonConverter(typeof(StringEnumConverter<UnofficialCurrencyCodeList>))]
public sealed record UnofficialCurrencyCodeList : OpenStringEnum<UnofficialCurrencyCodeList>
{
    private UnofficialCurrencyCodeList(string value) : base(value)
    {
    }

    public static readonly UnofficialCurrencyCodeList Ada = new("ADA");

    public static readonly UnofficialCurrencyCodeList Bat = new("BAT");

    public static readonly UnofficialCurrencyCodeList Bch = new("BCH");

    public static readonly UnofficialCurrencyCodeList Bnb = new("BNB");

    public static readonly UnofficialCurrencyCodeList Btc = new("BTC");

    public static readonly UnofficialCurrencyCodeList Btg = new("BTG");

    public static readonly UnofficialCurrencyCodeList Bsv = new("BSV");

    public static readonly UnofficialCurrencyCodeList Cnh = new("CNH");

    public static readonly UnofficialCurrencyCodeList Dash = new("DASH");

    public static readonly UnofficialCurrencyCodeList Doge = new("DOGE");

    public static readonly UnofficialCurrencyCodeList Etc = new("ETC");

    public static readonly UnofficialCurrencyCodeList Eth = new("ETH");

    public static readonly UnofficialCurrencyCodeList Gbx = new("GBX");

    public static readonly UnofficialCurrencyCodeList Lsk = new("LSK");

    public static readonly UnofficialCurrencyCodeList Neo = new("NEO");

    public static readonly UnofficialCurrencyCodeList Omg = new("OMG");

    public static readonly UnofficialCurrencyCodeList Qtum = new("QTUM");

    public static readonly UnofficialCurrencyCodeList Usdt = new("USDT");

    public static readonly UnofficialCurrencyCodeList Xlm = new("XLM");

    public static readonly UnofficialCurrencyCodeList Xmr = new("XMR");

    public static readonly UnofficialCurrencyCodeList Xrp = new("XRP");

    public static readonly UnofficialCurrencyCodeList Zec = new("ZEC");

    public static readonly UnofficialCurrencyCodeList Zrx = new("ZRX");

    public TResult Match<TResult>(Func<TResult> onAda,
        Func<TResult> onBat,
        Func<TResult> onBch,
        Func<TResult> onBnb,
        Func<TResult> onBtc,
        Func<TResult> onBtg,
        Func<TResult> onBsv,
        Func<TResult> onCnh,
        Func<TResult> onDash,
        Func<TResult> onDoge,
        Func<TResult> onEtc,
        Func<TResult> onEth,
        Func<TResult> onGbx,
        Func<TResult> onLsk,
        Func<TResult> onNeo,
        Func<TResult> onOmg,
        Func<TResult> onQtum,
        Func<TResult> onUsdt,
        Func<TResult> onXlm,
        Func<TResult> onXmr,
        Func<TResult> onXrp,
        Func<TResult> onZec,
        Func<TResult> onZrx,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ada => onAda(),
            _ when this == Bat => onBat(),
            _ when this == Bch => onBch(),
            _ when this == Bnb => onBnb(),
            _ when this == Btc => onBtc(),
            _ when this == Btg => onBtg(),
            _ when this == Bsv => onBsv(),
            _ when this == Cnh => onCnh(),
            _ when this == Dash => onDash(),
            _ when this == Doge => onDoge(),
            _ when this == Etc => onEtc(),
            _ when this == Eth => onEth(),
            _ when this == Gbx => onGbx(),
            _ when this == Lsk => onLsk(),
            _ when this == Neo => onNeo(),
            _ when this == Omg => onOmg(),
            _ when this == Qtum => onQtum(),
            _ when this == Usdt => onUsdt(),
            _ when this == Xlm => onXlm(),
            _ when this == Xmr => onXmr(),
            _ when this == Xrp => onXrp(),
            _ when this == Zec => onZec(),
            _ when this == Zrx => onZrx(),
            _ => otherwise(Value)
        };

    public void Match(Action onAda,
        Action onBat,
        Action onBch,
        Action onBnb,
        Action onBtc,
        Action onBtg,
        Action onBsv,
        Action onCnh,
        Action onDash,
        Action onDoge,
        Action onEtc,
        Action onEth,
        Action onGbx,
        Action onLsk,
        Action onNeo,
        Action onOmg,
        Action onQtum,
        Action onUsdt,
        Action onXlm,
        Action onXmr,
        Action onXrp,
        Action onZec,
        Action onZrx,
        Action<string> otherwise)
    {
        if (this == Ada) onAda();
        else if (this == Bat) onBat();
        else if (this == Bch) onBch();
        else if (this == Bnb) onBnb();
        else if (this == Btc) onBtc();
        else if (this == Btg) onBtg();
        else if (this == Bsv) onBsv();
        else if (this == Cnh) onCnh();
        else if (this == Dash) onDash();
        else if (this == Doge) onDoge();
        else if (this == Etc) onEtc();
        else if (this == Eth) onEth();
        else if (this == Gbx) onGbx();
        else if (this == Lsk) onLsk();
        else if (this == Neo) onNeo();
        else if (this == Omg) onOmg();
        else if (this == Qtum) onQtum();
        else if (this == Usdt) onUsdt();
        else if (this == Xlm) onXlm();
        else if (this == Xmr) onXmr();
        else if (this == Xrp) onXrp();
        else if (this == Zec) onZec();
        else if (this == Zrx) onZrx();
        else otherwise(Value);
    }
}
